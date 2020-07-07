using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ItVnpost.Utility.Startup
{
    public class Version
    {
        public static void AddVersion(IServiceCollection services)
        {
            services.AddApiVersioning(option =>
            {
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new ApiVersion(1, 0);
                option.ReportApiVersions = true;
            });
            services.AddVersionedApiExplorer(option => option.GroupNameFormat = "'v'VVV");
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen();
        }

        public static void UseVersion(IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                foreach (var desc in provider.ApiVersionDescriptions)
                {
                    option.SwaggerEndpoint($"/swagger/{desc.GroupName}/swagger.json",
                        desc.GroupName.ToUpperInvariant());
                    option.RoutePrefix = "";
                }
            });
        }
    }
}
