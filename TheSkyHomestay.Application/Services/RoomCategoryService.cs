using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.Application.Services
{
    public class RoomCategoryService : IRoomCategoryService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public RoomCategoryService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<RoomCategoryDTO>>> GetAllAsync()
        {
            var roomCategoryList = await _context.RoomCategories.Where(rc => rc.IsDeleted == false).Select(rc => _mapper.Map<RoomCategoryDTO>(rc)).ToListAsync();
            if(roomCategoryList.Count < 1)
            {
                return new ApiResult<List<RoomCategoryDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<RoomCategoryDTO>>(roomCategoryList)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<RoomCategoryDTO>> GetByIdAsync(int Id)
        {

            var roomcategory = await _context.RoomCategories.Where(rc => rc.IsDeleted == false && rc.Id==Id).FirstOrDefaultAsync();
            if (roomcategory == null)
            {
                return new ApiResult<RoomCategoryDTO>(null)
                {
                    Message = $"Couldn't find the room category with id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<RoomCategoryDTO>(_mapper.Map<RoomCategoryDTO>(roomcategory))
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> CreateAsync(CreateRoomCategoryDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newRoomCategory = _mapper.Map<RoomCategory>(request);
            await _context.RoomCategories.AddAsync(newRoomCategory);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Create new room category successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> EditAsync(EditRoomCategoryDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var roomcategory = await _context.RoomCategories.Where(rc => rc.IsDeleted == false && rc.Id == request.Id).FirstOrDefaultAsync();
            if (roomcategory == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = $"Couldn't find the room category with id: {request.Id}",
                    StatusCode = 404
                };
            }

            roomcategory.Name = request.Name;
            if (request.Image != "") roomcategory.Image = request.Image;
            roomcategory.UpdatedTime = DateTime.Now;
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Edit room category successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var roomcategory = await _context.RoomCategories.Where(rc => rc.IsDeleted == false && rc.Id == Id).FirstOrDefaultAsync();
            if (roomcategory == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = $"Couldn't find the room category with id: {Id}",
                    StatusCode = 404
                };
            }
            roomcategory.IsDeleted = true;
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = $"Delete room category with Id = {Id} successfully!",
                StatusCode = 200
            };
        }
    }
}
