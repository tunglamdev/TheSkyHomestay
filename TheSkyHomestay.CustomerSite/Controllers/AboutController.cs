using Microsoft.AspNetCore.Mvc;
using Refit;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.Integration.Interfaces;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class AboutController : Controller
    {
        private IRoomCategoryAPI _roomCategoryApi;
        private IServiceAPI _serviceApi;
        private IFeedbackAPI _feedbackAPI;
        private AboutViewModel _viewData;
        public AboutController()
        {
            _roomCategoryApi = RestService.For<IRoomCategoryAPI>("https://localhost:7241");
            _serviceApi = RestService.For<IServiceAPI>("https://localhost:7241");
            _feedbackAPI = RestService.For<IFeedbackAPI>("https://localhost:7241");
            _viewData = new AboutViewModel();
        }

        public IActionResult Index()
        {
            var roomCategories = _roomCategoryApi.GetAll().GetAwaiter().GetResult();
            var services = _serviceApi.GetAll().GetAwaiter().GetResult();
            var feedbacks = _feedbackAPI.GetAll().GetAwaiter().GetResult();
            _viewData.RoomCategories = roomCategories;
            _viewData.Services = services;
            _viewData.Feedbacks = feedbacks;
            return View(_viewData);
        }
    }
}
