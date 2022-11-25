using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Diagnostics;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.DTO.Feedback;
using TheSkyHomestay.Integration.Interfaces;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private IRoomCategoryAPI _roomCategoryApi;
        private IFeedbackAPI _feedbackAPI;
        private HomeViewModel _viewData;
        public HomeController()
        {
            _roomCategoryApi = RestService.For<IRoomCategoryAPI>("https://localhost:7241");
            _feedbackAPI = RestService.For<IFeedbackAPI>("https://localhost:7241");
            _viewData = new HomeViewModel();
        }

        public IActionResult Index()
        {
            var roomCategories = _roomCategoryApi.GetAll().GetAwaiter().GetResult();
            var feedbacks = _feedbackAPI.GetAll().GetAwaiter().GetResult();
            _viewData.RoomCategories = roomCategories;
            _viewData.Feedbacks = feedbacks;
            return View(_viewData);
        }

        [HttpPost]
        public IActionResult AddFeedback(CreateFeedbackDTO request)
        {
            var result = _feedbackAPI.Create(request).GetAwaiter().GetResult();
            return View(Index);
        }
    }
}