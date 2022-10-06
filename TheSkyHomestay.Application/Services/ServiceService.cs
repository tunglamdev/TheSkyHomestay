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
using TheSkyHomestay.DTO.Room;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.Application.Services
{
    public class ServiceService : IServiceService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public ServiceService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<ServiceDTO>>> GetAllAsync()
        {
            var serviceList = await _context.Services.Where(s => s.IsDeleted == false).Select(s => _mapper.Map<ServiceDTO>(s)).ToListAsync();
            if (serviceList.Count < 1)
            {
                return new ApiResult<List<ServiceDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<ServiceDTO>>(serviceList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<ServiceDTO>> GetByIdAsync(int Id)
        {
            var service = await _context.Services.Where(s => s.IsDeleted == false && s.Id == Id).FirstOrDefaultAsync();
            if (service == null)
            {
                return new ApiResult<ServiceDTO>(null)
                {
                    Message = $"Couldn't find the service with id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<ServiceDTO>(_mapper.Map<ServiceDTO>(service))
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> CreateAsync(CreateServiceDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newService = _mapper.Map<Service>(request);
            await _context.Services.AddAsync(newService);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Create new service successfully!",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> EditAsync(EditServiceDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var checkServiceExist = await GetByIdAsync(request.Id);
            if (checkServiceExist.StatusCode == 200)
            {
                var service = await _context.Services.Where(s => s.Id == request.Id).FirstOrDefaultAsync();
                service.Name = request.Name;
                service.Price = request.Price;
                service.Description = request.Description;
                service.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Edit service successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkServiceExist.Message,
                StatusCode = checkServiceExist.StatusCode
            };
        }
        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var checkServiceExist = await GetByIdAsync(Id);
            if (checkServiceExist.StatusCode == 200)
            {
                var service = await _context.Services.Where(s => s.Id == Id).FirstOrDefaultAsync();
                service.IsDeleted = true;
                service.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Delete service successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkServiceExist.Message,
                StatusCode = checkServiceExist.StatusCode
            };
        }
    }
}
