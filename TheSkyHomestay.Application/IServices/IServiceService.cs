using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.Application.IServices
{
    public interface IServiceService
    {
        public Task<ApiResult<List<ServiceDTO>>> GetAllAsync();
        public Task<ApiResult<ServiceDTO>> GetByIdAsync(int Id);
        public Task<ApiResult<bool>> CreateAsync(CreateServiceDTO request);
        public Task<ApiResult<bool>> EditAsync(EditServiceDTO request);
        public Task<ApiResult<bool>> DeleteAsync(int Id);
    }
}
