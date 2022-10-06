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
using TheSkyHomestay.DTO.Bill;
using TheSkyHomestay.DTO.Contants;

namespace TheSkyHomestay.Application.Services
{
    public class BillService : IBillService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public BillService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<BillDTO>> GetByIdAsync(int Id)
        {
            var bill = await _context.Bills
                .Include(b => b.Tourist)
                .Include(b => b.RoomBookings).ThenInclude(rb => rb.Room)
                .Include(b => b.ServiceBookings).ThenInclude(sb => sb.Service)
                .FirstAsync(x => x.Id == Id);
            var billDTO = _mapper.Map<BillDTO>(bill);
            if (billDTO == null)
            {
                return new ApiResult<BillDTO>(null)
                {
                    Message = $"Couldn't find the bill with Id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<BillDTO>(billDTO)
            {
                Message = "",
                StatusCode = 200
            };
        }
    }
}
