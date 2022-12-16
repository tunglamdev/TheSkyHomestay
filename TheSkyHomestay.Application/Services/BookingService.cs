using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Bill;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.Application.Services
{
    public class BookingService : IBookingService
    {
        private TheSkyHomestayDbContext _context;
        private IMapper _mapper;
        public BookingService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<int>> BookAsync(BookingDTO request)
        {
            //Create new bill
            var newBill = _mapper.Map<Bill>(request);
            await _context.Bills.AddAsync(newBill);
            await _context.SaveChangesAsync();

            //Create room booking
            decimal roomTotal = 0;
            var newBookedRoomList = _mapper.Map<List<RoomBooking>>(request.Rooms);
            foreach (var newBookedRoom in newBookedRoomList)
            {
                newBookedRoom.BillId = newBill.Id;
                await _context.RoomBookings.AddAsync(newBookedRoom);
                await _context.SaveChangesAsync();
                roomTotal = roomTotal + newBookedRoom.Total;
            }

            //Create service booking
            decimal serviceTotal = 0;
            var newBookedServiceList = _mapper.Map<List<ServiceBooking>>(request.Services);
            foreach (var newBookedService in newBookedServiceList)
            {
                newBookedService.BillId = newBill.Id;
                await _context.ServiceBookings.AddAsync(newBookedService);
                await _context.SaveChangesAsync();
                serviceTotal = serviceTotal + newBookedService.Total;
            }
            
            decimal total = roomTotal + serviceTotal;
            var bill = await _context.Bills.Where(b => b.Id == newBill.Id).FirstOrDefaultAsync();
            bill.Total = total;
            await _context.SaveChangesAsync();

            return new ApiResult<int>(newBill.Id)
            {
                Message = "Make a booking successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<BookingDetailDTO>> GetBookingDetailAsync(int billId)
        {
            var bookingDetail = new BookingDetailDTO();

            var bill = await _context.Bills
                .Include(b => b.Tourist)
                .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                .FirstAsync(x => x.Id == billId);

            var billDTO = _mapper.Map<BillDTO>(bill);

            bookingDetail.TouristName = billDTO.TouristName;
            bookingDetail.Email = billDTO.Email;
            bookingDetail.CINo = billDTO.CiNo;
            bookingDetail.PhoneNumber = billDTO.PhoneNumber;

            decimal total = 0;
            foreach (var room in billDTO.RoomBookings)
            {
                total = total + room.Total;
                bookingDetail.RoomName = room.Name;
                bookingDetail.Price = room.Price;
                bookingDetail.CheckInDate = room.CheckInDate;
                bookingDetail.CheckOutDate = room.CheckOutDate;
                bookingDetail.RoomId = room.Id;
                bookingDetail.NumberOfAdult = room.NumberOfAdult;
                bookingDetail.NumberOfChild = room.NumberOfChild;
            }
            bookingDetail.Services = new List<ServiceBookingDTO>();
            foreach (var service in billDTO.ServiceBookings)
            {
                total = total + service.Total;
                var s = new ServiceBookingDTO()
                {
                    Name = service.Name,
                    Image = service.Image,
                    Price = service.Price,
                    Amount = service.Amount,
                };
                bookingDetail.Services.Add(s);
            }
            bookingDetail.Total = total;

            return new ApiResult<BookingDetailDTO>(bookingDetail)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }

        public async Task<ApiResult<List<CheckInStatisticDTO>>> CheckInStatistic()
        {
            var currentDate = DateTime.Now;
            var lastSixMonthDate = currentDate.AddMonths(-5);

            var bookings = await _context.RoomBookings.Where(rb => DateTime.Compare(rb.CheckInDate, lastSixMonthDate) >= 0 &&
                                                                    DateTime.Compare(rb.CheckInDate , currentDate) <= 0)
                                                    .ToListAsync();
            var result = from b in bookings
                         group b by b.CheckInDate.Month into groupRersult
                         orderby groupRersult.Key
                         select groupRersult;

            var statisticList = new List<CheckInStatisticDTO>();
            foreach(var r in result)
            {
                var statistic = new CheckInStatisticDTO();
                statistic.Month = r.Key;
                statistic.NumberOfBooking = r.Count();
                statisticList.Add(statistic);
            }

            var lastResultList = new List<CheckInStatisticDTO>();
            for (var i = lastSixMonthDate.Month; i <= currentDate.Month; i++)
            {
                var isExist = false;
                foreach (var s in statisticList)
                {
                    if(s.Month == i)
                    {
                        isExist = true; break;
                    }
                }
                if (!isExist) {
                    var statistic = new CheckInStatisticDTO();
                    statistic.Month = i;
                    statistic.NumberOfBooking = 0;
                    lastResultList.Add(statistic);
                }
            }

            lastResultList.AddRange(statisticList);

            return new ApiResult<List<CheckInStatisticDTO>>(lastResultList)
            {
                Message = "Seccessfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<RevenueStatisticDTO>>> RevenueStatistic() {
            var currentDate = DateTime.Now;
            var result = new List<RevenueStatisticDTO>();
            for(var i = 5; i >= 0; i--)
            {
                var revenueStatistic = await GetRevenueByMonth(currentDate.AddMonths(0 - i).Month, currentDate.AddMonths(0 - i).Year);
                var newStatistic = new RevenueStatisticDTO()
                {
                    Month = currentDate.AddMonths(0 - i).Month,
                    Revenue = revenueStatistic.Data.Revenue
                };
                result.Add(newStatistic);
            }
            
            return new ApiResult<List<RevenueStatisticDTO>>(result)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }
        
        public async Task<ApiResult<RevenueDTO>> GetRevenueByDate(DateTime date)
        {
            date = date.AddHours(12);
            var billIdList = await _context.RoomBookings.Where(rb => DateTime.Compare(rb.CheckInDate, date) == 0)
                                .Select(rb => rb.BillId).ToListAsync();
            var bookingList = new List<BookingDetailDTO>();
            foreach(var billId in billIdList)
            {
                var bookingDetail = new BookingDetailDTO();

                var bill = await _context.Bills
                    .Include(b => b.Tourist)
                    .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                    .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                    .FirstAsync(x => x.Id == billId);

                var billDTO = _mapper.Map<BillDTO>(bill);

                bookingDetail.TouristName = billDTO.TouristName;
                bookingDetail.Email = billDTO.Email;
                bookingDetail.CINo = billDTO.CiNo;
                bookingDetail.PhoneNumber = billDTO.PhoneNumber;
                bookingDetail.Total = billDTO.Total;

                decimal total = 0;
                foreach (var room in billDTO.RoomBookings)
                {
                    total = total + room.Total;
                    bookingDetail.RoomName = room.Name;
                    bookingDetail.Price = room.Price;
                    bookingDetail.CheckInDate = room.CheckInDate;
                    bookingDetail.CheckOutDate = room.CheckOutDate;
                    bookingDetail.RoomId = room.Id;
                    bookingDetail.NumberOfAdult = room.NumberOfAdult;
                    bookingDetail.NumberOfChild = room.NumberOfChild;
                }
                bookingDetail.Services = new List<ServiceBookingDTO>();
                foreach (var service in billDTO.ServiceBookings)
                {
                    total = total + service.Total;
                    var s = new ServiceBookingDTO()
                    {
                        Name = service.Name,
                        Image = service.Image,
                        Price = service.Price,
                        Amount = service.Amount,
                    };
                    bookingDetail.Services.Add(s);
                }
                bookingDetail.Total = total;
                bookingList.Add(bookingDetail);
            }
            decimal rev = 0;
            foreach(var booking in bookingList)
            {
                rev = rev + booking.Total;
            }

            var revenue = new RevenueDTO()
            {
                BookingList = bookingList,
                NumberOfChecking = bookingList.Count(),
                Revenue = rev
            };
            return new ApiResult<RevenueDTO>(revenue)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }

        public async Task<ApiResult<RevenueDTO>> GetRevenueByMonth(int month, int year)
        {
            var billIdList = await _context.RoomBookings.Where(rb => rb.CheckInDate.Month == month && rb.CheckInDate.Year==year)
                                .Select(rb => rb.BillId).ToListAsync();
            var bookingList = new List<BookingDetailDTO>();
            foreach (var billId in billIdList)
            {
                var bookingDetail = new BookingDetailDTO();

                var bill = await _context.Bills
                    .Include(b => b.Tourist)
                    .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                    .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                    .FirstAsync(x => x.Id == billId);

                var billDTO = _mapper.Map<BillDTO>(bill);

                bookingDetail.TouristName = billDTO.TouristName;
                bookingDetail.Email = billDTO.Email;
                bookingDetail.CINo = billDTO.CiNo;
                bookingDetail.PhoneNumber = billDTO.PhoneNumber;
                bookingDetail.Total = billDTO.Total;

                decimal total = 0;
                foreach (var room in billDTO.RoomBookings)
                {
                    total = total + room.Total;
                    bookingDetail.RoomName = room.Name;
                    bookingDetail.Price = room.Price;
                    bookingDetail.CheckInDate = room.CheckInDate;
                    bookingDetail.CheckOutDate = room.CheckOutDate;
                    bookingDetail.RoomId = room.Id;
                    bookingDetail.NumberOfAdult = room.NumberOfAdult;
                    bookingDetail.NumberOfChild = room.NumberOfChild;
                }
                bookingDetail.Services = new List<ServiceBookingDTO>();
                foreach (var service in billDTO.ServiceBookings)
                {
                    total = total + service.Total;
                    var s = new ServiceBookingDTO()
                    {
                        Name = service.Name,
                        Image = service.Image,
                        Price = service.Price,
                        Amount = service.Amount,
                    };
                    bookingDetail.Services.Add(s);
                }
                bookingDetail.Total = total;
                bookingList.Add(bookingDetail);
            }
            decimal rev = 0;
            foreach (var booking in bookingList)
            {
                rev = rev + booking.Total;
            }

            var revenue = new RevenueDTO()
            {
                BookingList = bookingList,
                NumberOfChecking = bookingList.Count(),
                Revenue = rev
            };
            return new ApiResult<RevenueDTO>(revenue)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }

        public async Task<ApiResult<RevenueDTO>> GetRevenueByQuarter(int year, int quarter)
        {
            var billIdList = new List<int>();
            if (quarter == 1)
            {
                billIdList = await _context.RoomBookings
                                            .Where(rb => (rb.CheckInDate.Month == 1 ||
                                                            rb.CheckInDate.Month == 2 ||
                                                            rb.CheckInDate.Month == 3) &&
                                                            rb.CheckInDate.Year == year)
                                            .Select(rb => rb.BillId).ToListAsync();
            }
            else if(quarter == 2)
            {
                billIdList = await _context.RoomBookings
                                           .Where(rb => (rb.CheckInDate.Month == 4 ||
                                                           rb.CheckInDate.Month == 5 ||
                                                           rb.CheckInDate.Month == 6) &&
                                                           rb.CheckInDate.Year == year)
                                           .Select(rb => rb.BillId).ToListAsync();
            }
            else if(quarter == 3)
            {
                billIdList = await _context.RoomBookings
                                           .Where(rb => (rb.CheckInDate.Month == 7 ||
                                                           rb.CheckInDate.Month == 8 ||
                                                           rb.CheckInDate.Month == 9) &&
                                                           rb.CheckInDate.Year == year)
                                           .Select(rb => rb.BillId).ToListAsync();
            }
            else
            {
                billIdList = await _context.RoomBookings
                                           .Where(rb => (rb.CheckInDate.Month == 10 ||
                                                           rb.CheckInDate.Month == 11 ||
                                                           rb.CheckInDate.Month == 12) &&
                                                           rb.CheckInDate.Year == year)
                                           .Select(rb => rb.BillId).ToListAsync();
            }


            var bookingList = new List<BookingDetailDTO>();
            foreach (var billId in billIdList)
            {
                var bookingDetail = new BookingDetailDTO();

                var bill = await _context.Bills
                    .Include(b => b.Tourist)
                    .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                    .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                    .FirstAsync(x => x.Id == billId);

                var billDTO = _mapper.Map<BillDTO>(bill);

                bookingDetail.TouristName = billDTO.TouristName;
                bookingDetail.Email = billDTO.Email;
                bookingDetail.CINo = billDTO.CiNo;
                bookingDetail.PhoneNumber = billDTO.PhoneNumber;
                bookingDetail.Total = billDTO.Total;

                decimal total = 0;
                foreach (var room in billDTO.RoomBookings)
                {
                    total = total + room.Total;
                    bookingDetail.RoomName = room.Name;
                    bookingDetail.Price = room.Price;
                    bookingDetail.CheckInDate = room.CheckInDate;
                    bookingDetail.CheckOutDate = room.CheckOutDate;
                    bookingDetail.RoomId = room.Id;
                    bookingDetail.NumberOfAdult = room.NumberOfAdult;
                    bookingDetail.NumberOfChild = room.NumberOfChild;
                }
                bookingDetail.Services = new List<ServiceBookingDTO>();
                foreach (var service in billDTO.ServiceBookings)
                {
                    total = total + service.Total;
                    var s = new ServiceBookingDTO()
                    {
                        Name = service.Name,
                        Image = service.Image,
                        Price = service.Price,
                        Amount = service.Amount,
                    };
                    bookingDetail.Services.Add(s);
                }
                bookingDetail.Total = total;
                bookingList.Add(bookingDetail);
            }
            decimal rev = 0;
            foreach (var booking in bookingList)
            {
                rev = rev + booking.Total;
            }

            var revenue = new RevenueDTO()
            {
                BookingList = bookingList,
                NumberOfChecking = bookingList.Count(),
                Revenue = rev
            };
            return new ApiResult<RevenueDTO>(revenue)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }

        public async Task<ApiResult<RevenueDTO>> GetRevenueByYear(int year)
        {
            var billIdList = await _context.RoomBookings.Where(rb => rb.CheckInDate.Year == year)
                                .Select(rb => rb.BillId).ToListAsync();
            var bookingList = new List<BookingDetailDTO>();
            foreach (var billId in billIdList)
            {
                var bookingDetail = new BookingDetailDTO();

                var bill = await _context.Bills
                    .Include(b => b.Tourist)
                    .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                    .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                    .FirstAsync(x => x.Id == billId);

                var billDTO = _mapper.Map<BillDTO>(bill);

                bookingDetail.TouristName = billDTO.TouristName;
                bookingDetail.Email = billDTO.Email;
                bookingDetail.CINo = billDTO.CiNo;
                bookingDetail.PhoneNumber = billDTO.PhoneNumber;
                bookingDetail.Total = billDTO.Total;

                decimal total = 0;
                foreach (var room in billDTO.RoomBookings)
                {
                    total = total + room.Total;
                    bookingDetail.RoomName = room.Name;
                    bookingDetail.Price = room.Price;
                    bookingDetail.CheckInDate = room.CheckInDate;
                    bookingDetail.CheckOutDate = room.CheckOutDate;
                    bookingDetail.RoomId = room.Id;
                    bookingDetail.NumberOfAdult = room.NumberOfAdult;
                    bookingDetail.NumberOfChild = room.NumberOfChild;
                }
                bookingDetail.Services = new List<ServiceBookingDTO>();
                foreach (var service in billDTO.ServiceBookings)
                {
                    total = total + service.Total;
                    var s = new ServiceBookingDTO()
                    {
                        Name = service.Name,
                        Image = service.Image,
                        Price = service.Price,
                        Amount = service.Amount,
                    };
                    bookingDetail.Services.Add(s);
                }
                bookingDetail.Total = total;
                bookingList.Add(bookingDetail);
            }
            decimal rev = 0;
            foreach (var booking in bookingList)
            {
                rev = rev + booking.Total;
            }

            var revenue = new RevenueDTO()
            {
                BookingList = bookingList,
                NumberOfChecking = bookingList.Count(),
                Revenue = rev
            };
            return new ApiResult<RevenueDTO>(revenue)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }
    }
}
