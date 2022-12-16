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
using TheSkyHomestay.DTO.Feedback;

namespace TheSkyHomestay.Application.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public FeedbackService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<FeedbackDTO>>> GetAllAsync()
        {
            var feedbacks = await _context.Feedbacks
                .Include(f => f.Tourist)
                .Where(f => f.IsDeleted == false)
                .Select(f => _mapper.Map<FeedbackDTO>(f)).ToListAsync();
            if(feedbacks == null)
            {
                return new ApiResult<List<FeedbackDTO>>(null)
                {
                    StatusCode = 400,
                    Message = "Something went wrong!"
                };
            }
            return new ApiResult<List<FeedbackDTO>>(feedbacks)
            {
                StatusCode = 200,
                Message = "Get feedbacks list successfully!"
            };
        }

        public async Task<ApiResult<bool>> CreateAsync(CreateFeedbackDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newFeedback = _mapper.Map<Feedback>(request);
            await _context.AddAsync(newFeedback);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Create new feedback successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var feedback = await _context.Feedbacks.Where(fb => fb.IsDeleted == false && fb.Id == Id).FirstOrDefaultAsync();
            if (feedback == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = $"Couldn't find the feedback with id: {Id}",
                    StatusCode = 404
                };
            }
            feedback.IsDeleted = true;
            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = $"Delete the feedback with Id = {Id} successfully!",
                StatusCode = 200
            };
        }
    }
}
