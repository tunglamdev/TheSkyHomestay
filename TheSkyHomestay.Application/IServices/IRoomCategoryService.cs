using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.Application.IServices
{
    public interface IRoomCategoryService
    {
        public Task<ApiResult<List<RoomCategoryDTO>>> GetAllAsync();
        public Task<ApiResult<RoomCategoryDTO>> GetByIdAsync(int Id);
        public Task<ApiResult<bool>> CreateAsync(CreateRoomCategoryDTO request);
        public Task<ApiResult<bool>> EditAsync(EditRoomCategoryDTO request);
        public Task<ApiResult<bool>> DeleteAsync(int Id);
    }
}
