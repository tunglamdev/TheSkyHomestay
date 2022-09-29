using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.Application.Services
{
    public class RoomCategoryService : IRoomCategoryService
    {
        private readonly TheSkyHomestayDbContext _context;
        public RoomCategoryService(TheSkyHomestayDbContext context)
        {
            _context = context;
        }
        public async Task<List<RoomCategoryDTO>> GetAllAsync()
        {
            return await _context.RoomCategories.Where(rc => rc.IsDeleted == false).Select(rc => new RoomCategoryDTO()
            {
                Id = rc.Id,
                Name = rc.Name,
                CreatedTime = rc.CreatedTime,
                UpdatedTime = rc.UpdatedTime
             }).ToListAsync();
        }

        public async Task<RoomCategoryDTO> GetByIdAsync(int Id)
        {
            return await _context.RoomCategories.Where(rc => rc.IsDeleted == false && rc.Id==Id).Select(rc => new RoomCategoryDTO()
            {
                Id = rc.Id,
                Name = rc.Name,
                CreatedTime = rc.CreatedTime,
                UpdatedTime = rc.UpdatedTime
            }).FirstOrDefaultAsync();
        }
    }
}
