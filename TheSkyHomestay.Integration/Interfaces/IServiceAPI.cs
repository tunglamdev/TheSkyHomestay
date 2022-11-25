using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IServiceAPI
    {
        [Get("/api/Services")]
        public Task<List<ServiceDTO>> GetAll();
    }
}
