using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreDemo.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public  MapProfile()
        {
            CreateMap<AnnouncementAddDTO,Announcement>();
            CreateMap<Announcement,AnnouncementAddDTO>();
            
            CreateMap<AppUserRegisterDTO, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTO>();

            CreateMap<AppUserSignInDTO, AppUser>();
            CreateMap<AppUser, AppUserSignInDTO>();

            CreateMap<AnnouncementListDto,Announcement>();
            CreateMap<Announcement, AnnouncementListDto>();
            
            CreateMap<AnnouncementUpdateDto, Announcement>();
            CreateMap<Announcement,AnnouncementUpdateDto>();
            
            CreateMap<SendMessageDTO, ContactUs>().ReverseMap();
            


        }
    }
}
