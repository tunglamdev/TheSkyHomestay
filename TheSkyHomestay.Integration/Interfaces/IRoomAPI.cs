using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IRoomAPI
    {
        [Get("/api/Rooms")]
        public Task<List<RoomDTO>> GetAll();

        [Get("/api/Rooms/Category/{CategoryId}")]
        public Task<List<RoomDTO>> GetByCategoryId(int CategoryId);

        [Post("/api/Rooms/GetByChecking")]
        public Task<List<RoomDTO>> GetByChecking(RoomCheckingDTO request);

        [Post("/api/Rooms/GetByCheckingByCategory")]
        public Task<List<RoomDTO>> GetByCheckingByCategory(RoomCheckingByCategoryDTO request);

        [Get("/api/Rooms/{Id}")]
        public Task<RoomDTO> GetById(int Id);
    }
}
