using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Feedback;

namespace TheSkyHomestay.Application.IServices
{
    public interface IFeedbackService
    {
        public Task<ApiResult<List<FeedbackDTO>>> GetAllAsync();
        public Task<ApiResult<bool>> CreateAsync(CreateFeedbackDTO request);
    }
}
