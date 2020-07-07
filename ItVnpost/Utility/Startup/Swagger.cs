using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ItVnpost.Utility.Startup
{
    public class Swagger
    {
        private static readonly string[] _listName = { "MenuAdjustment", "Menu", "User", "News" };

        public static void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                foreach (string name in _listName)
                {
                    CreateSwaggerDoc(option, name);
                }
                var xmlCommenntFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var cmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommenntFile);
                option.IncludeXmlComments(cmlCommentsFullPath);
            });
        }

        public static void UseSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                foreach (string name in _listName)
                {
                    option.SwaggerEndpoint("/swagger/" + name + "/swagger.json", name);
                }
                option.RoutePrefix = "";
            });
        }

        private static void CreateSwaggerDoc(SwaggerGenOptions option, string name)
        {
            option.SwaggerDoc(name,
                       new Microsoft.OpenApi.Models.OpenApiInfo()
                       {
                           Title = "Tài liệu về cách lấy dữ liệu, thêm, sửa, xoá cho " + name,
                           Version = "1"
                       });
        }
    }
}
