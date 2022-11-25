using Refit;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IRoomCategoryAPI
    {
        [Get("/api/RoomCategories")]
        public Task<List<RoomCategoryDTO>> GetAll();
    }
}
