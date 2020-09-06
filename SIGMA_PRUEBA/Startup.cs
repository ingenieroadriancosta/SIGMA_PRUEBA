using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SIGMA_PRUEBA.Models;
using Microsoft.Data.Sqlite;

namespace SIGMA_PRUEBA
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
            
            services.AddMvc().AddRazorOptions(options =>
            {
                //options.PageViewLocationFormats.Add("/Pages/{0}.cshtml");
            });

            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });


            services.AddControllersWithViews();


            services.AddEntityFrameworkSqlite().AddDbContext<DbContextSIGMA>();
            services.AddDbContext<DbContextSIGMA>(options => options.UseSqlite(Configuration.GetConnectionString("Sqlite")));
            // CONFIGURACION DE SQLITE IN-MEMORY
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            services.AddDbContext<DbContextSIGMA>(options =>
                options.UseSqlite(connection));
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseStatusCodePages();
            app.UseStatusCodePagesWithReExecute("/");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
