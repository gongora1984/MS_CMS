using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace CMSSERVICE.WEB.Configuration;

public class PresentationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        ////#region COOKIE POLICY CONFIGURATION
        ////services.AddCookiePolicy(options =>
        ////{
        ////    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        ////    options.CheckConsentNeeded = context => true;
        ////    options.MinimumSameSitePolicy = SameSiteMode.None;
        ////});
        ////#endregion

        services
            .AddControllers()
            .AddApplicationPart(PRESENTATION.AssemblyReference.Assembly);

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "CMS SERVICE v1", Version = "v1" });
            c.AddSecurityDefinition("BearerAuth", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Scheme = JwtBearerDefaults.AuthenticationScheme.ToLowerInvariant(),
                In = ParameterLocation.Header,
                Name = "Authorization",
                BearerFormat = "JWT",
                Description = "JWT Authorization header using the Bearer scheme."
            });
        });

        #region CONFIGURING CORS
        services.AddCors(options =>
        {
            options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        });
        #endregion
    }
}
