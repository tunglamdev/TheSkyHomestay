using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Image;
using TheSkyHomestay.DTO.Service;
using static System.Net.Mime.MediaTypeNames;

namespace TheSkyHomestay.Application.Services
{
    public class ImageService : IImageService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public ImageService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<ImageDTO>>> GetByRoomIdAsync(int RoomId)
        {
            var imageList = await _context.RoomImages.Where(i => i.RoomId == RoomId && i.IsDeleted==false).Select(i => _mapper.Map<ImageDTO>(i)).ToListAsync();
            if (imageList.Count < 1)
            {
                return new ApiResult<List<ImageDTO>>(null)
                {
                    Message = "Photo list is empty!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<ImageDTO>>(imageList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<ImageDTO>> GetByIdAsync(int Id)
        {
            var image = await _context.RoomImages.Where(i => i.Id == Id && i.IsDeleted == false).Select(i => _mapper.Map<ImageDTO>(i)).FirstOrDefaultAsync();
            if (image == null)
            {
                return new ApiResult<ImageDTO>(null)
                {
                    Message = $"Couldn't find the photo with id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<ImageDTO>(image)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> CreateAsync(CreateImageDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newImage = _mapper.Map<RoomImage>(request);
            await _context.RoomImages.AddAsync(newImage);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Create new image successfully!",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var checkImageExist = await GetByIdAsync(Id);
            if(checkImageExist.StatusCode == 200)
            {
                var image = await _context.RoomImages.Where(i => i.Id == Id).FirstOrDefaultAsync();
                image.IsDeleted = true;
                await _context.SaveChangesAsync();
                return new ApiResult<bool>(true)
                {
                    Message = "Delete photo successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkImageExist.Message,
                StatusCode = checkImageExist.StatusCode
            };
        }
        //private async Task<string> SaveFileAsync(IFormFile file)
        //{
        //    //if (file == null)
        //    //{
        //    //    throw new GeeksBakeryException("Cannot add null file");
        //    //}
        //    //var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        //    //var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
        //    //await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        //    //return fileName;
        //}
    }
}
