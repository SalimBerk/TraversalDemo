using BusinessLayer.Abstract;
using BusinessLayer.Abstract.UnitOfWorkService;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UowManager;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IUnitOfWorkDal, UoWDal>();


        }
        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();

        }
    }
}
