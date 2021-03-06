using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistencia;


namespace FrontEnd
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
            services.AddRazorPages();
            services.AddScoped<IRepositorioPersonas, RepositorioPersona>();
            services.AddScoped<IRepositorioEmpleado, RepositorioEmpleado>();
            services.AddScoped<IRepositorioEmpresa, RepositorioEmpresa>();
            services.AddScoped<IRepositorioCliente, RepositorioCliente>();
            services.AddScoped<IRepositorioProveedor, RepositorioProveedor>();
            services.AddScoped<IRepositorioInventario, RepositorioInventario>();
            services.AddScoped<IRepositorioDirectivo, RepositorioDirectivo>();
            //services.AddSingleton<IRepositorioPersonas, RepositorioPersona>();//
            //services.AddSingleton<Persistencia.AplicationDbContext>();//
            services.AddDbContext<AplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnetion")));
            services.AddControllersWithViews();//importante
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
            app.UseStaticFiles();//importante
            app.UseAuthentication();//importante
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                //endpoints.MapAreaControllerRoute(name= "default", pattern ="{controller=conference}/{action=index}/{id?}");
            });
        }
    }
}
