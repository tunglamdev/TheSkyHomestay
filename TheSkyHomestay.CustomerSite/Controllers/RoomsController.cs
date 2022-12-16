using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Globalization;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.CustomerSite.Others;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Email;
using TheSkyHomestay.DTO.Room;
using TheSkyHomestay.DTO.Tourist;
using TheSkyHomestay.Integration.Interfaces;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class RoomsController : Controller
    { 
        private IRoomAPI _roomApi;
        private IServiceAPI _serviceApi;
        private IUserAPI _userApi;
        private IBookingAPI _bookingApi;
        private IEmailAPI _emailApi;
        private RoomsViewModel _viewData;
        public RoomsController()
        {
            _roomApi = RestService.For<IRoomAPI>("https://localhost:7241");
            _serviceApi = RestService.For<IServiceAPI>("https://localhost:7241");
            _userApi = RestService.For<IUserAPI>("https://localhost:7241");
            _bookingApi = RestService.For<IBookingAPI>("https://localhost:7241");
            _emailApi = RestService.For<IEmailAPI>("https://localhost:7241");
            _viewData = new RoomsViewModel();
        }
        public IActionResult Index()
        {
            var rooms = _roomApi.GetAll().GetAwaiter().GetResult();
            _viewData.Rooms = rooms;
            return View(_viewData);
        }

        public IActionResult Category(int Id)
        {
            var rooms = _roomApi.GetByCategoryId(Id).GetAwaiter().GetResult();
            _viewData.Rooms = rooms;
            _viewData.CategoryId = Id;
            return View(_viewData);
        }

        public IActionResult Check(string CheckInDate, string CheckOutDate)
        {
            var request = new RoomCheckingDTO()
            {
                FromDate = DateTime.Parse(CheckInDate),
                ToDate = DateTime.Parse(CheckOutDate)
            };
            var rooms = _roomApi.GetByChecking(request).GetAwaiter().GetResult();
            _viewData.Rooms = rooms;
            _viewData.CheckInDate = request.FromDate.AddHours(12);
            _viewData.CheckOutDate = request.ToDate.AddHours(12);
            return View(_viewData); 
        }

        public IActionResult CheckByCategory(int CategoryId, string CheckInDate, string CheckOutDate)
        {
            var request = new RoomCheckingByCategoryDTO()
            {
                FromDate = DateTime.Parse(CheckInDate),
                ToDate = DateTime.Parse(CheckOutDate),
                CategoryId = CategoryId
            };
            var rooms = _roomApi.GetByCheckingByCategory(request).GetAwaiter().GetResult();
            _viewData.Rooms = rooms;
            _viewData.CheckInDate = request.FromDate.AddHours(12);
            _viewData.CheckOutDate = request.ToDate.AddHours(12);
            _viewData.CategoryId = CategoryId;
            return View(_viewData);
        }

        public IActionResult Detail(int Id)
        {
            var room = _roomApi.GetById(Id).GetAwaiter().GetResult();
            _viewData.Room = room;
            return View(_viewData);
        }

        [HttpPost]
        public IActionResult Booking(int Id, string CheckInDate, string CheckOutDate)
        {
            var room = _roomApi.GetById(Id).GetAwaiter().GetResult();
            _viewData.Room = room;
            var services = _serviceApi.GetAll().GetAwaiter().GetResult();
            _viewData.Services = services;
            _viewData.CheckInDate = DateTime.Parse(CheckInDate);
            _viewData.CheckOutDate = DateTime.Parse(CheckOutDate);
            _viewData.RoomTotal = (decimal)(DateTime.Parse(CheckOutDate) - DateTime.Parse(CheckInDate)).TotalDays * room.Price;
            return View(_viewData);
        }

        [HttpPost]
        public async Task<IActionResult> BookingDetail(AnonymousBookingDTO request)
        {
            if (!ModelState.IsValid)
            {
                return Booking(request.RoomId, request.CheckInDate, request.CheckOutDate);
            }
            //Check request
            if (request.Name == null ||
                request.CINo == null ||
                request.PhoneNumber == null ||
                request.Email == null)
            {
                _viewData.ErrorMessage = "Vui lòng nhập đầy đủ thông tin đặt phòng!";
            }
            var newUserId = new Guid("00000000-0000-0000-0000-000000000000");
            string userId = User.Claims.Where(c => c.Type == "id").Select(c => c.Value).SingleOrDefault();
            if(userId == null)
            {
                //Create new anonymous account
                var newUserDTO = new RegisterAnonymousDTO()
                {
                    Name = request.Name,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    CINo = request.CINo
                };
                newUserId = _userApi.RegisterAnonymous(newUserDTO).GetAwaiter().GetResult();
                
            }
            else
            {
                newUserId = new Guid(userId);
            }
            var userIdCheck = new Guid("00000000-0000-0000-0000-000000000000");
            if (newUserId == userIdCheck)
            {
                // Xác nhận qua email
                return View(_viewData);
            }

            //Create new booking
            var newBookingDTO = new BookingDTO()
            {
                TouristId = newUserId,
                Rooms = new List<CreateRoomBookingDTO>() {
                    new CreateRoomBookingDTO()
                    {
                        RoomId = request.RoomId,
                        CheckInDate = DateTime.Parse(request.CheckInDate),
                        CheckOutDate = DateTime.Parse(request.CheckOutDate),
                        Price = request.Price,
                        NumberOfAdult = request.NumberOfAdult,
                        NumberOfChild = request.NumberOfChild,
                        Total = (decimal)(DateTime.Parse(request.CheckOutDate) - DateTime.Parse(request.CheckInDate)).TotalDays * request.Price,
                    }
                },
                Services = new List<CreateServiceBookingDTO>()
            };

            decimal servicesTotal = 0;
            if (request.Services != null)
            {
                for(var i = 0; i< request.Services.Count; i++)
                {
                    var newService = _serviceApi.GetById(request.Services.ElementAt(i)).GetAwaiter().GetResult();
                    var service = new CreateServiceBookingDTO()
                    {
                        ServiceId = newService.Id,
                        Price = newService.Price,
                        Amount = request.AmountService.ElementAt(i),
                        Total = request.AmountService.ElementAt(i) * newService.Price,
                    };
                    newBookingDTO.Services.Add(service);
                    servicesTotal = servicesTotal + service.Total;
                };
            }
            var billId = _bookingApi.CreateBooking(newBookingDTO).GetAwaiter().GetResult();

            return Payment(billId, (decimal)(DateTime.Parse(request.CheckOutDate) - DateTime.Parse(request.CheckInDate)).TotalDays * request.Price + servicesTotal);
        }

        public IActionResult Payment(int BillId, decimal Total)
        {
            string url = "http://sandbox.vnpayment.vn/paymentv2/vpcpay.html";
            string returnUrl = "https://localhost:7265/rooms/bookingresult";
            string tmnCode = "RQX9LXX9";
            string hashSecret = "SUIAIIFJYUIPNZEUWTZZFNXHFOQHAJDB";
            string price = Decimal.Round(Total * 100).ToString();

            PayLib pay = new PayLib();

            pay.AddRequestData("vnp_Version", "2.1.0"); //Phiên bản api mà merchant kết nối. Phiên bản hiện tại là 2.1.0
            pay.AddRequestData("vnp_Command", "pay"); //Mã API sử dụng, mã cho giao dịch thanh toán là 'pay'
            pay.AddRequestData("vnp_TmnCode", tmnCode); //Mã website của merchant trên hệ thống của VNPAY (khi đăng ký tài khoản sẽ có trong mail VNPAY gửi về)
            pay.AddRequestData("vnp_Amount", price); //số tiền cần thanh toán, công thức: số tiền * 100 - ví dụ 10.000 (mười nghìn đồng) --> 1000000
            pay.AddRequestData("vnp_BankCode", ""); //Mã Ngân hàng thanh toán (tham khảo: https://sandbox.vnpayment.vn/apis/danh-sach-ngan-hang/), có thể để trống, người dùng có thể chọn trên cổng thanh toán VNPAY
            pay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss")); //ngày thanh toán theo định dạng yyyyMMddHHmmss
            pay.AddRequestData("vnp_CurrCode", "VND"); //Đơn vị tiền tệ sử dụng thanh toán. Hiện tại chỉ hỗ trợ VND
            pay.AddRequestData("vnp_IpAddr", Util.GetIpAddress()); //Địa chỉ IP của khách hàng thực hiện giao dịch
            pay.AddRequestData("vnp_Locale", "vn"); //Ngôn ngữ giao diện hiển thị - Tiếng Việt (vn), Tiếng Anh (en)
            pay.AddRequestData("vnp_OrderInfo", "Thanh toan tien dat phong"); //Thông tin mô tả nội dung thanh toán
            pay.AddRequestData("vnp_OrderType", "other"); //topup: Nạp tiền điện thoại - billpayment: Thanh toán hóa đơn - fashion: Thời trang - other: Thanh toán trực tuyến
            pay.AddRequestData("vnp_ReturnUrl", returnUrl); //URL thông báo kết quả giao dịch khi Khách hàng kết thúc thanh toán
            pay.AddRequestData("vnp_TxnRef", BillId.ToString()); //mã hóa đơn
            string paymentUrl = pay.CreateRequestUrl(url, hashSecret);

            return Redirect(paymentUrl);
        }

        public IActionResult BookingResult()
        {
            var vnpayData = HttpContext.Request.Query;
            PayLib pay = new PayLib();

            //Get data returned from VNPay
            foreach (var s in vnpayData)
            {
                if (!string.IsNullOrEmpty(s.Value) && s.Key.StartsWith("vnp_"))
                {
                    pay.AddResponseData(s.Key, s.Value);
                }
            }

            int BillId = Int32.Parse(pay.GetResponseData("vnp_TxnRef"));

            //Get booking info
            var result = _bookingApi.GetBookingDetail(BillId).GetAwaiter().GetResult();

            //Send email
            var sendEmailDTO = new SendEmailDTO();
            sendEmailDTO.To = result.Email;
            sendEmailDTO.Subject = "[The Sky Homestay Hòn Sơn] Xác nhận đặt phòng";
            sendEmailDTO.Body = $"<h3>Xin chào du khách {result.TouristName}</h3>";
            sendEmailDTO.Body += $"<p>Lời đầu tiên xin được chân thành cảm ơn du khách đã tin tưởng sử dụng dịch vụ lưu trú tại The Sky Homestay.</p>";
            sendEmailDTO.Body += $"<p>The Sky Homestay xin được xác nhận với du khách về thông tin đặt phòng như sau:</p>";
            sendEmailDTO.Body += $"<ul>" +
            $"<li>Tên phòng đã đặt: {result.RoomName} </li>" +
                                    $"<li>Ngày check-in nhận phòng: {result.CheckInDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)}</li>" +
                                    $"<li>Ngày check-out trả phòng: {result.CheckOutDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)}</li>" +
                                $"</ul>";
            if (result.Services.Count != 0)
            {
                sendEmailDTO.Body += $"<p>*Các dịch vụ đã đặt kèm theo:</p>";
                sendEmailDTO.Body += $"<ul>";
                foreach (var service in result.Services)
                {
                    sendEmailDTO.Body += $"<li>{service.Name}: {@String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", service.Price)}/lượt ({service.Amount} lượt)</li>";
                }
                sendEmailDTO.Body += $"</ul>";
            }
            sendEmailDTO.Body += $"<h2>Số tiền đã thanh toán: {@String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", result.Total)}</h2>";
            sendEmailDTO.Body += $"<p>Quý du khách vui lòng kiểm tra lại thông tin và liên hệ ngay với chúng tôi nếu có sai sót!</p>";
            sendEmailDTO.Body += $"<p>The Sky Homestay Hòn Sơn rất hân hạnh được phục vụ quý du khách!</p>";
            sendEmailDTO.Body += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            sendEmailDTO.Body += $"<ul>" +
                                    $"<li>Email: theskyhomestay.honson@gmail.com</li>" +
                                    $"<li>Số điện thoại: 0338 307 449 (gặp Thu)</li>" +
                                    $"<li>Địa chỉ: 123 Ấp Bấc, xã Lại Sơn, huyện Kiên Hải, tỉnh Kiên Giang</li>" +
                                $"</ul>";

            _emailApi.SendEmail(sendEmailDTO);

            var room = _roomApi.GetById(result.RoomId).GetAwaiter().GetResult();
            _viewData.Room = room;
            _viewData.Room.Price = result.Price;
            _viewData.CheckInDate = result.CheckInDate;
            _viewData.CheckOutDate = result.CheckOutDate;
            _viewData.TouristName = result.TouristName;
            _viewData.Email = result.Email;
            _viewData.PhoneNumber = result.PhoneNumber;
            _viewData.CINo = result.CINo;
            _viewData.Total = result.Total;
            _viewData.ServiceBooking = result.Services;
            return View(_viewData);
        }
    }
}