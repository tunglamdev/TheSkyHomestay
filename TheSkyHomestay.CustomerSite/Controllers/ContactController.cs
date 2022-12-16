using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Globalization;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.DTO.Email;
using TheSkyHomestay.Integration.Interfaces;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class ContactController : Controller
    {
        private IEmailAPI _emailApi;
        private ContactViewModel _viewData;
        public ContactController()
        {
            _emailApi = RestService.For<IEmailAPI>("https://localhost:7241");
            _viewData = new ContactViewModel();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string subject, string content)
        {
            //Send email
            var sendEmailDTO = new SendEmailDTO();
            sendEmailDTO.To = "theskyhomestay.honson@gmail.com";
            sendEmailDTO.Subject = subject;
            sendEmailDTO.Body = $"<p>{content}</p>";
            sendEmailDTO.Body += $"<h3>Thông tin từ du khách {name}</h3>";
            _emailApi.SendEmailFromGuest(sendEmailDTO);
            TempData["Message"] = "Thông tin đã được gửi, vui lòng kiểm tra email để nhận phản hồi sớm nhất!";
            return RedirectToAction("Index", "Contact");
        }
    }
}
