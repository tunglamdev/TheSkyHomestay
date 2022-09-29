using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.Application.IServices
{
    public interface IRoomCategoryService
    {
        public Task<List<RoomCategoryDTO>> GetAllAsync();
        public Task<RoomCategoryDTO> GetByIdAsync(int Id);
        //public Task<int> CreateAsync(CategoryCreateRequest request);
        //public Task<string> UpdateAsync(CategoryUpdateRequest request);
        //public Task<int> DeleteAsync(int Id);
    }
}
