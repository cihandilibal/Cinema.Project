using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Managers.Abstracts;
using Project.BLL.Managers.Concretes;
using Project.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class ManagerService
    {
        public static IServiceCollection AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IBoxOfficeManager, BoxOfficeManager>();
            services.AddScoped<IFilmManager, FilmManager>();
            services.AddScoped<IPaymentManager, PaymentManager>();
            services.AddScoped<ISeatManager, SeatManager>();
            services.AddScoped<ITheaterManager, TheaterManager>();
            
            return services;
        }
    }
}
