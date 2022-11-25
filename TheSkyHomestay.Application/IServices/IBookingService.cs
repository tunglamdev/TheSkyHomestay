using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Contants;

namespace TheSkyHomestay.Application.IServices
{
    public interface IBookingService
    {
        public Task<ApiResult<int>> BookAsync(BookingDTO request);
        public Task<ApiResult<BookingDetailDTO>> GetBookingDetailAsync(int billId);
    }
}
