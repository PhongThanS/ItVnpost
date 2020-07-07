using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.Extensions.DependencyInjection;

namespace ItVnpost
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var desc in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    desc.GroupName, new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = $"ItVnpost {desc.ApiVersion}",
                        Version = desc.ApiVersion.ToString(),
                    });
            }
        }
    }
}