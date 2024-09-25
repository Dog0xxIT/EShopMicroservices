using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Identity.Api
{
    public static class DependencyInjectionExtensions
    {
        public static void AddJwtAuthentication(this IHostApplicationBuilder builder)
        {
            var jwtConfig = new JwtConfig();
            builder.Configuration.GetSection(jwtConfig.SectionName).Bind(jwtConfig);
            builder.Services.AddSingleton(jwtConfig);

            builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = jwtConfig.Issuer,
                        ValidAudience = jwtConfig.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.SecretKey)),
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            context.Token = context.Request.Cookies["jwt"]; // Get token from cookie
                            return Task.CompletedTask;
                        },
                    };
                });
        }
    }
}
