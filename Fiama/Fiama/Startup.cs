
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories;
using Repository.Repositories.AuthRepositories;
using Repository.Repositories.ContentRepositories;
using AutoMapper;
using Repository.Repositories.ShoppingRepositories;
using Fiama.Libs;
using Microsoft.AspNetCore.Http;
using Fiama.Libs.AuthFilter;

namespace Fiama
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
            services.AddDbContext<FiamaDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConnection"),x=> x.MigrationsAssembly("Fiama")));
            services.AddControllersWithViews();

            services.AddMvc(
                config => {
                    config.Filters.Add(new GlobalToken());
                
                });



            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IContentRepository, ContentRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IBasketRepository, BasketRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();


            //inner lips
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAuth, Auth>();
            
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
