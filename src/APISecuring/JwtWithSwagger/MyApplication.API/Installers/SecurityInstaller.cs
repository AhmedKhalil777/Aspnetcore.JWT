using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApplication.API.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.API.Installers
{
    public static class SecurityInstaller
    {
        public static void InstallSecurity(this IServiceCollection services ,  IConfiguration configuration)
        {
            var jwtOptions = new JwtOptions();
            configuration.GetSection(nameof(JwtOptions)).Bind(jwtOptions);

            services.AddAuthentication(options=> { 
                options.DefaultScheme =  JwtBearerDefaults
            }).
                
        }
    }
}
