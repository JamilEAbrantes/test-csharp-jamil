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
using Microsoft.OpenApi.Models;
using System;

namespace Candidate.Web.API
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
            services.AddControllers();

            var assembly = AppDomain.CurrentDomain.Load("Candidate.Application");

            services.AddMediatR(assembly);

            services.AddAutoMapper(assembly);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<ICandidateExperienceRepository, CandidateExperienceRepository>();

            services.AddDbContext<CandidateDBContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    o => o.MigrationsAssembly("Candidate.Web.API"))
                );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Prova InfoJobs", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Jamallll");
            });
        }
    }
}