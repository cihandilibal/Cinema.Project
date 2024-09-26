using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.CONF.Configurations;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext: IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext>options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new FilmConfiguration());
            builder.ApplyConfiguration(new BoxOfficeConfiguration());
            builder.ApplyConfiguration(new SeatConfiguration());
            builder.ApplyConfiguration(new TheaterConfiguration());
            builder.ApplyConfiguration(new PaymentConfiguration());

        }

        public DbSet<AppUser>AppUsers { get; set; }
        public DbSet<BoxOffice>BoxOffices { get; set; }
        public DbSet<Seat>Seats { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
