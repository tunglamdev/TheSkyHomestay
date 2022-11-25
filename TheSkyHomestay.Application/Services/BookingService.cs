using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
            var newBookedRoomList = _mapper.Map<List<RoomBooking>>(request.Rooms);
            foreach (var newBookedRoom in newBookedRoomList)
            {
                newBookedRoom.BillId = newBill.Id;
                await _context.RoomBookings.AddAsync(newBookedRoom);
                await _context.SaveChangesAsync();
            }

            //Create service booking
            var newBookedServiceList = _mapper.Map<List<ServiceBooking>>(request.Services);
            foreach (var newBookedService in newBookedServiceList)
            {
                newBookedService.BillId = newBill.Id;
                await _context.ServiceBookings.AddAsync(newBookedService);
                await _context.SaveChangesAsync();
            }

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
            foreach(var room in billDTO.RoomBookings)
            {
                total = total + room.Total;
                bookingDetail.RoomName = room.Name;
                bookingDetail.CheckInDate = room.CheckInDate;
                bookingDetail.CheckOutDate = room.CheckOutDate;
                bookingDetail.RoomId = room.Id;
            }
            bookingDetail.Total = total;

            return new ApiResult<BookingDetailDTO>(bookingDetail)
            {
                StatusCode = 200,
                Message = "Successfully!"
            };
        }
    }
}
