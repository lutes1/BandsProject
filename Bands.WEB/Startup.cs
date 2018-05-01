using AutoMapper;
using Bands.BLL;
using Bands.BLL.Abstractions;
using Bands.BLL.ServicesImplementations;
using Bands.DAL;
using Bands.DAL.Abstractions;
using Bands.DAL.Repositories;
using Bands.Domains;
using Bands.Domains.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bands.WEB.Services;

namespace Bands.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(DatabaseRepository<>));

            services.AddScoped(typeof(IMusiciansRepository), typeof(MusiciansRepository));

            services.AddScoped(typeof(IBandsRepository), typeof(BandsRepository));

            services.AddScoped(typeof(IBandsServices), typeof(BandsServices));

            services.AddScoped(typeof(IMusiciansServices), typeof(MusiciansServices));

            services.AddScoped(typeof(IMusicianInterestsRepository), typeof(MusicianInterestsRepository));

            services.AddScoped(typeof(IInterestsRepository), typeof(InterestsRepository));

            services.AddScoped(typeof(IMusicianTypeRepository), typeof(MusicianTypeRepository));

            services.AddIdentity<ApplicationUser, IdentityRole<long>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            services.AddAutoMapper();
            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
