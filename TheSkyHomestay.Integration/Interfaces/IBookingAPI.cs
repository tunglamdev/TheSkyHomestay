using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Feedback;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IBookingAPI
    {
        [Post("/api/Bookings/Book")]
        public Task<int> CreateBooking(BookingDTO request);

        [Get("/api/Bookings/GetBookingDetail/{billId}")]
        public Task<BookingDetailDTO> GetBookingDetail(int billId);
    }
}
