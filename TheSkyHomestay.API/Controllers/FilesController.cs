using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using TheSkyHomestay.DTO.Image;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FilesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("{FolderName}")]
        public async Task<string> Post([FromForm] UploadFileDTO FileUploaded, [FromRoute] string FolderName)
        {
            try
            {
                if (FileUploaded.File.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\images\\" + FolderName + "\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var originalFileName = ContentDispositionHeaderValue.Parse(FileUploaded.File.ContentDisposition).FileName.Trim('"');
                    var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";

                    using (FileStream fileStrem = System.IO.File.Create(path + fileName))
                    {
                        FileUploaded.File.CopyTo(fileStrem);
                        fileStrem.Flush();
                        return fileName;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpDelete("{FolderName}/{FileName}")]
        public async Task<string> Delete([FromRoute] string FolderName, [FromRoute] string FileName)
        {
            try
            {
                string path = _webHostEnvironment.WebRootPath + "\\images\\" + FolderName + "\\" + FileName;
                if (System.IO.File.Exists(@path))
                {
                    System.IO.File.Delete(@path);
                    return "Delete Done!";
                }
                return "Not found image path";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpGet("{FileName}")]
        public async Task<IActionResult> Get([FromRoute] string FileName)
        {
            string path = _webHostEnvironment.WebRootPath + "\\images\\";
            var filePath = path + FileName + ".jpg";
            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);
                return File(b, "image/jpg");
            }
            return null;
        }
    }
}
