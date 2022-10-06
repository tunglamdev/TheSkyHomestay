using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Bill;
using TheSkyHomestay.DTO.Contants;

namespace TheSkyHomestay.Application.IServices
{
    public interface IBillService
    {
        public Task<ApiResult<BillDTO>> GetByIdAsync(int Id);
    }
}
