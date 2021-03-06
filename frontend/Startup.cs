using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Authentication;
using DNPAssignment1FamilyManagementSystem.Data;
using DNPAssignment1FamilyManagementSystem.Data.Impl;
using DNPAssignment1FamilyManagementSystem.Models;
using DNPAssignment1FamilyManagementSystem.Models.Util;
using DNPAssignment1FamilyManagementSystem.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DNPAssignment1FamilyManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<FileContext>();
            services.AddScoped<IFamilyService, WebFamilyService>();
            services.AddScoped<IUserService, WebUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<IEventCoordinator, EventCoordinator>();
            services.AddScoped<IFamilyStatisticsService, FamilyStatisticsService>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("IsUser", a=> a.RequireClaim("Role", "User"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}