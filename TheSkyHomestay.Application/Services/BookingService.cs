using AutoMapper;
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

        public async Task<ApiResult<bool>> BookAsync(BookingDTO request)
        {
            //check request
            //....
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

            return new ApiResult<bool>(true)
            {
                Message = "Make a booking successfully!",
                StatusCode = 200
            };
        }
    }
}
