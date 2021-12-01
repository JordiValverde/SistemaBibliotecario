using JLCS.SB.CapaDatos;
using ServiciosBackground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using JLCS.SB.Sistema_de_Informacion_Bibliotecario.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using JLCS.SB.Sistema_de_Informacion_Bibliotecario.Utilidades;
using Microsoft.AspNetCore.Http;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario
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
            //Localization
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.ConfigureRequestLocalization();
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddViewLocalization(o => o.ResourcesPath = "Recursos")
                .AddRazorPagesOptions(o => {
                    o.Conventions.Add(new CultureTemplateRouteModelConvention());
                });
            services.AddSingleton<CultureLocalizer>();

            //Base de Datos
            services.AddDbContext<CapaDatos.ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("JLCS.SB.CapaDatos")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<CapaDatos.ApplicationDbContext>();
            //Añadir RazorPages
            services.AddRazorPages();
            //añadir signalr
            services.AddSignalR();

            //SweetAlert
            services.AddSession();

            //codigo para crear archivos temporales en backgroung, me olvide de resolverlo
            services.AddHostedService<IntervalTaskHostedService>();

            //services.AddMvc();
            //services.AddCaching();
            //services.AddSession(opciones => { 
            //    options.IdleTimeout = TimeSpan.FromMinutes(30);
            //    options.CookieName = ".Library";
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRequestLocalization();
            app.UseCookiePolicy();
            app.UseRouting();
            //var localizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value;
            //app.UseRequestLocalization(localizationOptions);
            //sweetAlert

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<PositionHub>("/positionhub");
            });
            //app.MapSignalR();
        }
    }
}
