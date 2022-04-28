using System;
using Candidate.Domain.CandidateAggregate;
using Candidate.Domain.CandidateExperienceAggregate;
using Candidate.Infra.Data;
using Candidate.Infra.Data.Candidate;
using Candidate.Infra.Data.CandidateExperience;
using Candidate.Infra.Data.UoW;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Candidate.Web.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            var assembly = AppDomain.CurrentDomain.Load("Candidate.Application");

            services.AddMediatR(assembly);

            services.AddAutoMapper(assembly);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<ICandidateExperienceRepository, CandidateExperienceRepository>();

            services.AddDbContext<CandidateDBContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    o => o.MigrationsAssembly("Candidate.Web.MVC"))
                );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Shared/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Candidate}/{action=Index}/{id?}");
            });
        }
    }
}