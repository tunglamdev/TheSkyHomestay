using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        public RoomService(TheSkyHomestayDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<RoomDTO>>> GetAllAsync()
        {
            var roomList = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false)
                .Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();

            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<RoomDTO>>> GetByCheckingAsync(RoomCheckingDTO request)
        {
            request.FromDate = request.FromDate.AddHours(12);
            request.ToDate = request.ToDate.AddHours(12);
            var roomList = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false)
                .Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();

            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var fromMonth = request.FromDate.Month;
            var toMonth = request.ToDate.Month;
            var fromDay = request.FromDate.Day;
            var toDay = request.ToDate.Day;

            var roomBookingList = await _context.RoomBookings
                                                .Where(rb => 
                                                rb.CheckInDate.Month == fromMonth ||
                                                rb.CheckInDate.Month == toMonth ||
                                                rb.CheckOutDate.Month == fromMonth ||
                                                rb.CheckOutDate.Month == toMonth).ToListAsync();
            var bookedRooms = new List<int>();

            foreach (var room in roomList)
            {
                var flag = false;
                foreach (var roomBooking in roomBookingList)
                {
                    if (room.Id == roomBooking.RoomId)
                    {
                        if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) >= 0 && DateTime.Compare(request.FromDate, roomBooking.CheckOutDate) < 0)
                        {
                            flag = true;
                            break;
                        }
                        else if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) < 0)
                        {
                            if (DateTime.Compare(request.ToDate, roomBooking.CheckInDate) > 0)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    else continue;
                }

                if(flag == true) bookedRooms.Add(room.Id);
            }
            foreach (var r in roomList)
            {
                if (bookedRooms.Contains(r.Id)) r.State = Data.Models.Enums.RoomStateEnum.Booked;
                else r.State = Data.Models.Enums.RoomStateEnum.Available;
            }

            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<RoomDTO>>> GetByCheckingByCategoryAsync(RoomCheckingByCategoryDTO request)
        {
            var roomList = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false && r.CategoryId == request.CategoryId)
                .Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();

            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var fromMonth = request.FromDate.Month;
            var toMonth = request.ToDate.Month;
            var fromDay = request.FromDate.Day;
            var toDay = request.ToDate.Day;

            var roomBookingList = await _context.RoomBookings
                                                .Where(rb =>
                                                rb.CheckInDate.Month == fromMonth ||
                                                rb.CheckInDate.Month == toMonth ||
                                                rb.CheckOutDate.Month == fromMonth ||
                                                rb.CheckOutDate.Month == toMonth).ToListAsync();
            var bookedRooms = new List<int>();

            foreach (var room in roomList)
            {
                var flag = false;
                foreach (var roomBooking in roomBookingList)
                {
                    if (room.Id == roomBooking.RoomId)
                    {
                        if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) >= 0 && DateTime.Compare(request.FromDate, roomBooking.CheckOutDate) < 0)
                        {
                            flag = true;
                            break;
                        }
                        else if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) < 0)
                        {
                            if (DateTime.Compare(request.ToDate, roomBooking.CheckInDate) > 0)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    else continue;
                }

                if (flag == true) bookedRooms.Add(room.Id);
            }
            foreach (var r in roomList)
            {
                if (bookedRooms.Contains(r.Id)) r.State = Data.Models.Enums.RoomStateEnum.Booked;
                else r.State = Data.Models.Enums.RoomStateEnum.Available;
            }

            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<AdminCheckRoomDTO>>> GetByAdminCheckingAsync(RoomCheckingDTO request)
        {
            request.FromDate = request.FromDate.AddHours(12);
            request.ToDate = request.ToDate.AddHours(12);
            var roomList = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false)
                .Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();

            if (roomList.Count < 1)
            {
                return new ApiResult<List<AdminCheckRoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var checkRoomList = new List<AdminCheckRoomDTO>();
            foreach(var room in roomList)
            {
                checkRoomList.Add(new AdminCheckRoomDTO()
                {
                    Room = room,
                    BookedTime = new List<DTO.Bookings.BookedTimeDTO>()
                });
            }
            var fromMonth = request.FromDate.Month;
            var toMonth = request.ToDate.Month;
            var fromDay = request.FromDate.Day;
            var toDay = request.ToDate.Day;

            var roomBookingList = await _context.RoomBookings
                                                .Where(rb =>
                                                rb.CheckInDate.Month == fromMonth ||
                                                rb.CheckInDate.Month == toMonth ||
                                                rb.CheckOutDate.Month == fromMonth ||
                                                rb.CheckOutDate.Month == toMonth).ToListAsync();

            foreach (var room in checkRoomList)
            {
                var flag = false;
                foreach (var roomBooking in roomBookingList)
                {
                    if (room.Room.Id == roomBooking.RoomId)
                    {
                        if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) >= 0 && DateTime.Compare(request.FromDate, roomBooking.CheckOutDate) < 0)
                        {
                            room.Room.State = Data.Models.Enums.RoomStateEnum.Booked;
                            var bookedTime = new DTO.Bookings.BookedTimeDTO()
                            {
                                BookedCheckInDate = roomBooking.CheckInDate,
                                BookedCheckOutDate = roomBooking.CheckOutDate,
                            };
                            room.BookedTime.Add(bookedTime);
                            flag = true;
                        }
                        else if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) < 0)
                        {
                            if (DateTime.Compare(request.ToDate, roomBooking.CheckInDate) > 0)
                            {
                                room.Room.State = Data.Models.Enums.RoomStateEnum.Booked;
                                var bookedTime = new DTO.Bookings.BookedTimeDTO()
                                {
                                    BookedCheckInDate = roomBooking.CheckInDate,
                                    BookedCheckOutDate = roomBooking.CheckOutDate,
                                };
                                room.BookedTime.Add(bookedTime);
                                flag = true;
                            }
                        }
                    }
                    else continue;
                }
                if (!flag) room.Room.State = Data.Models.Enums.RoomStateEnum.Available;
            }

            return new ApiResult<List<AdminCheckRoomDTO>>(checkRoomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<BookingDetailDTO>>> GetBookingDetailAsync(CheckBookingDetailDTO request)
        {
            var bookingDetailList = new List<BookingDetailDTO>();

            request.FromDate = request.FromDate.AddHours(12);
            request.ToDate = request.ToDate.AddHours(12);
            var fromMonth = request.FromDate.Month;
            var toMonth = request.ToDate.Month;
            var fromDay = request.FromDate.Day;
            var toDay = request.ToDate.Day;

            var roomBookingList = await _context.RoomBookings
                                                .Include(rb => rb.Bill).ThenInclude(b => b.Tourist)
                                                .Where(rb =>
                                                ((DateTime.Compare(rb.CheckInDate, request.FromDate)<=0 && DateTime.Compare(rb.CheckOutDate, request.FromDate)>0) ||
                                                (DateTime.Compare(rb.CheckInDate, request.FromDate) >0 && DateTime.Compare(rb.CheckInDate, request.ToDate) <0)) &&
                                                rb.RoomId == request.RoomId).ToListAsync();

            foreach (var roomBooking in roomBookingList)
            {
                if (request.RoomId == roomBooking.RoomId)
                {
                    if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) >= 0 && DateTime.Compare(request.FromDate, roomBooking.CheckOutDate) < 0)
                    {
                        bookingDetailList.Add(new BookingDetailDTO()
                        {
                            Name = roomBooking.Bill.Tourist.Name,
                            Email = roomBooking.Bill.Tourist.Email,
                            PhoneNumber = roomBooking.Bill.Tourist.PhoneNumber,
                            CINo = roomBooking.Bill.Tourist.CINo,
                            CheckInDate = roomBooking.CheckInDate,
                            CheckOutDate = roomBooking.CheckOutDate
                        });
                    }
                    else if (DateTime.Compare(request.FromDate, roomBooking.CheckInDate) < 0)
                    {
                        if (DateTime.Compare(request.ToDate, roomBooking.CheckInDate) > 0)
                        {
                            bookingDetailList.Add(new BookingDetailDTO()
                            {
                                Name = roomBooking.Bill.Tourist.Name,
                                Email = roomBooking.Bill.Tourist.Email,
                                PhoneNumber = roomBooking.Bill.Tourist.PhoneNumber,
                                CINo = roomBooking.Bill.Tourist.CINo,
                                CheckInDate = roomBooking.CheckInDate,
                                CheckOutDate = roomBooking.CheckOutDate
                            });
                        }
                    }
                }
                else continue;
            }

            return new ApiResult<List<BookingDetailDTO>>(bookingDetailList);
        }
        public async Task<ApiResult<RoomDTO>> GetByIdAsync(int Id)
        {
            var room = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false && r.Id == Id)
                .Select(r => _mapper.Map<RoomDTO>(r)).FirstOrDefaultAsync();
            
            if(room == null)
            {
                return new ApiResult<RoomDTO>(null)
                {
                    Message = $"Couldn't find the room with id: {Id}",
                    StatusCode = 404
                };
            }
            return new ApiResult<RoomDTO>(_mapper.Map<RoomDTO>(room))
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<RoomDTO>>> GetByCategoryIdAsync(int CategoryId)
        {
            var roomList = await _context.Rooms
                .Include(r => r.Images.Where(i => i.IsDeleted == false))
                .Where(r => r.IsDeleted == false && r.CategoryId == CategoryId)
                .Select(r => _mapper.Map<RoomDTO>(r)).ToListAsync();
            if (roomList.Count < 1)
            {
                return new ApiResult<List<RoomDTO>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<RoomDTO>>(roomList)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<int>> CreateAsync(CreateRoomDTO request)
        {
            if (request == null)
            {
                return new ApiResult<int>(0)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var newRoom = _mapper.Map<Room>(request);
            await _context.Rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();
            return new ApiResult<int>(newRoom.Id)
            {
                Message = "Create new room successfully!",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<bool>> EditAsync(EditRoomDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var checkRoomExist = await GetByIdAsync(request.Id);
            if(checkRoomExist.StatusCode == 200)
            {
                var category = await _context.RoomCategories.Where(rc => rc.Id == request.CategoryId).FirstOrDefaultAsync();
                if(category==null) return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
                var room = await _context.Rooms.Where(r => r.Id == request.Id).FirstOrDefaultAsync();
                room.Name = request.Name;
                room.Price = request.Price;
                room.CategoryId = request.CategoryId;
                room.Description = request.Description;
                room.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Edit room successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkRoomExist.Message,
                StatusCode = checkRoomExist.StatusCode
            };
        }
        public async Task<ApiResult<bool>> DeleteAsync(int Id)
        {
            var checkRoomExist = await GetByIdAsync(Id);
            if (checkRoomExist.StatusCode == 200)
            {
                var room = await _context.Rooms.Where(r => r.Id == Id).FirstOrDefaultAsync();
                room.IsDeleted = true;
                room.UpdatedTime = DateTime.Now;
                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    Message = "Delete room successfully!",
                    StatusCode = 200
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = checkRoomExist.Message,
                StatusCode = checkRoomExist.StatusCode
            };
        }
    }
}
