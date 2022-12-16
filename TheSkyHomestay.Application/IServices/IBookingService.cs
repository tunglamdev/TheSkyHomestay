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
        public Task<ApiResult<List<CheckInStatisticDTO>>> CheckInStatistic();
        public Task<ApiResult<List<RevenueStatisticDTO>>> RevenueStatistic();
        public Task<ApiResult<RevenueDTO>> GetRevenueByDate(DateTime date);
        public Task<ApiResult<RevenueDTO>> GetRevenueByMonth(int month, int year);
        public Task<ApiResult<RevenueDTO>> GetRevenueByQuarter(int year, int quarter);
        public Task<ApiResult<RevenueDTO>> GetRevenueByYear(int year);

    }
}
