using AutoMapper;
using ItVnpost.DataAccess.Data;
using ItVnpost.DataAccess.Data.Repository;
using ItVnpost.Models;
using ItVnpost.Models.Mapper;
using ItVnpost.Repository.IRepository;
using ItVnpost.Utility.Startup;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ItVnpost
{
    public class Startup
    {
        readonly string AppCors = "";
        readonly string AcceptRoute = "http://10.141.23.108:5500";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            services.AddCors(options =>
            {
                options.AddPolicy(name: AppCors,
                                  builder =>
                                  {
                                      builder.WithOrigins(AcceptRoute);
                                  });
            });
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(VnpostMappings));
            //Swagger.AddSwagger(services);
            Version.AddVersion(services);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            //Swagger.UseSwagger(app);
            Version.UseVersion(app, provider);
            app.UseRouting();

            app.UseCors(AppCors);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
