using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Image;

namespace TheSkyHomestay.Application.IServices
{
    public interface IImageService
    {
        public Task<ApiResult<List<ImageDTO>>> GetByRoomIdAsync(int RoomId);
        public Task<ApiResult<ImageDTO>> GetByIdAsync(int Id);
        public Task<ApiResult<bool>> CreateAsync(CreateImageDTO request);
        public Task<ApiResult<bool>> DeleteAsync(int Id);
    }
}
