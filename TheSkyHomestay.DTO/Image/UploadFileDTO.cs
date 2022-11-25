using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Image
{
    public class UploadFileDTO
    {
        public IFormFile File { set; get; }
    }
}
