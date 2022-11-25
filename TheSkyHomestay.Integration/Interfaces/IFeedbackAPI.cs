using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Feedback;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IFeedbackAPI
    {
        [Get("/api/Feedbacks")]
        public Task<List<FeedbackDTO>> GetAll();

        [Post("/api/Feedbacks")]
        public Task<bool> Create(CreateFeedbackDTO request);
    }
}
