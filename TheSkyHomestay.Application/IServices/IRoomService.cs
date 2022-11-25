using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.Application.IServices
{
    public interface IRoomService
    {
        public Task<ApiResult<List<RoomDTO>>> GetAllAsync();
        public Task<ApiResult<List<RoomDTO>>> GetByCheckingAsync(RoomCheckingDTO request);
        public Task<ApiResult<List<RoomDTO>>> GetByCheckingByCategoryAsync(RoomCheckingByCategoryDTO request);
        public Task<ApiResult<List<AdminCheckRoomDTO>>> GetByAdminCheckingAsync(RoomCheckingDTO request);
        public Task<ApiResult<RoomDTO>> GetByIdAsync(int Id);
        public Task<ApiResult<List<RoomDTO>>> GetByCategoryIdAsync(int CaterogyId);
        public Task<ApiResult<List<BookingDetailDTO>>> GetBookingDetailAsync(CheckBookingDetailDTO request);
        public Task<ApiResult<int>> CreateAsync(CreateRoomDTO request);
        public Task<ApiResult<bool>> EditAsync(EditRoomDTO request);
        public Task<ApiResult<bool>> DeleteAsync(int Id);
    }
}
