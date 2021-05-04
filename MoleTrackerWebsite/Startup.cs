using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataClasses.Domain;
using PW_BusinessLogicLayer;
using PW_BusinessLogicLayer.Interfaces;

namespace MoleTrackerWebsite
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

            services.AddTransient<LogInInfo>();
            services.AddSingleton<SessionInfo>();
            services.AddSingleton<ILogInController, LogInController>();
            services.AddSingleton<PatientInfo>();
            services.AddSingleton<Collection>();
            services.AddSingleton<DoctorInfo>();
            services.AddSingleton<LocationOnBody>();
            services.AddSingleton<PictureInfo>();
            services.AddSingleton<CoordinatesLocalization>();
            services.AddSingleton<IChangeCollectionNameController, ChangeCollectionNameController>();
            services.AddSingleton<IViewCollectionController, ViewCollectionController>();
            services.AddSingleton<IUploadPictureController, UploadPictureController>();
            services.AddSingleton<IDeletePictureController, DeletePictureController>();
            services.AddSingleton<IDeleteCollectionController, DeleteCollectionController>();
            services.AddSingleton<IChangeFollowUpNotificationsController, ChangeFollowUpNotificationsController>();
            services.AddSingleton<IMarkCollectionController, MarkCollectionController>();
            services.AddSingleton<ILoadContactInformationController, LoadContactInformationController>();
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
