using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IBoxOfficeRepository, BoxOfficeRepository>();
            services.AddScoped<ITheaterRepository, TheaterRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            
            return services;
        }
        



    }
}
