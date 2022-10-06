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
        public Task<ApiResult<RoomDTO>> GetByIdAsync(int Id);
        public Task<ApiResult<List<RoomDTO>>> GetByCategoryIdAsync(int CaterogyId);
        public Task<ApiResult<bool>> CreateAsync(CreateRoomDTO request);
        public Task<ApiResult<bool>> EditAsync(EditRoomDTO request);
        public Task<ApiResult<bool>> DeleteAsync(int Id);
    }
}
