using Microsoft.AspNetCore.Mvc;
using Refit;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.Integration.Interfaces;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class ServicesController : Controller
    {
        private IServiceAPI _serviceApi;
        private ServicesViewModel _viewData;
        public ServicesController()
        {
            _serviceApi = RestService.For<IServiceAPI>("https://localhost:7241");
            _viewData = new ServicesViewModel();
        }
        public IActionResult Index()
        {
            var services = _serviceApi.GetAll().GetAwaiter().GetResult();
            _viewData.Services = services;
            return View(_viewData);
        }
    }
}
