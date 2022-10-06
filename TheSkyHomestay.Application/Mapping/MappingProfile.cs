using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Room;
using TheSkyHomestay.DTO.Service;
using TheSkyHomestay.DTO.Image;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Bill;

namespace TheSkyHomestay.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Room category mapping
            CreateMap<RoomCategory, RoomCategoryDTO>().ReverseMap();
            CreateMap<CreateRoomCategoryDTO, RoomCategory>();

            //Room mapping
            CreateMap<RoomDTO, Room>().ReverseMap();
            CreateMap<CreateRoomDTO, Room>();

            //Service mapping
            CreateMap<ServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>();

            //Image mapping
            CreateMap<ImageDTO, RoomImage>().ReverseMap();
            CreateMap<CreateImageDTO, RoomImage>();

            //Roombooking mapping
            CreateMap<RoomBooking, RoomBookingDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(rb => rb.Room.Name));
            CreateMap<CreateRoomBookingDTO, RoomBooking>();

            //Servicebooking mapping
            CreateMap<ServiceBooking, ServiceBookingDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(sb => sb.Service.Name));
            CreateMap<CreateServiceBookingDTO, ServiceBooking>();

            //Bill mapping
            CreateMap<Bill, BillDTO>()
                .ForMember(dto => dto.TouristName, opt => opt.MapFrom(b => b.Tourist.Name))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(b => b.Tourist.PhoneNumber));

            //Booking mapping
            CreateMap<BookingDTO, Bill>();
        }
    }
}
