using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public RoomService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<RoomDTO>>> GetAllAsync()
        {
            var roomList = await _context.Rooms.Where(r => r.IsDeleted == false).Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();
            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<RoomDTO>> GetByIdAsync(int Id)
        {
            var room = await _context.Rooms.Where(r => r.IsDeleted == false && r.Id == Id).FirstOrDefaultAsync();
            if (room == null)
            {
                return new ApiResult<RoomDTO>(null)
                {
                    Message = $"Couldn't find the room with id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<RoomDTO>(_mapper.Map<RoomDTO>(room))
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<RoomDTO>>> GetByCategoryIdAsync(int CategoryId)
        {
            var roomList = await _context.Rooms.Where(r => r.IsDeleted == false && r.CategoryId == CategoryId).Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();
            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> CreateAsync(CreateRoomDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newRoom = _mapper.Map<Room>(request);
            await _context.Rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Create new room successfully!",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> EditAsync(EditRoomDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var checkRoomExist = await GetByIdAsync(request.Id);
            if(checkRoomExist.StatusCode == 200)
            {
                var room = await _context.Rooms.Where(r => r.Id == request.Id).FirstOrDefaultAsync();
                room.Name = request.Name;
                room.Price = request.Price;
                room.CategoryId = request.CategoryId;
                room.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Edit room successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkRoomExist.Message,
                StatusCode = checkRoomExist.StatusCode
            };
        }
        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var checkRoomExist = await GetByIdAsync(Id);
            if (checkRoomExist.StatusCode == 200)
            {
                var room = await _context.Rooms.Where(r => r.Id == Id).FirstOrDefaultAsync();
                room.IsDeleted = true;
                room.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Delete room successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkRoomExist.Message,
                StatusCode = checkRoomExist.StatusCode
            };
        }
    }
}
