using TheSkyHomestay.DTO.Feedback;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.CustomerSite.Models
{
    public class AboutViewModel
    {
        public List<RoomCategoryDTO> RoomCategories;
        public List<ServiceDTO> Services;
        public List<FeedbackDTO> Feedbacks;
    }
}