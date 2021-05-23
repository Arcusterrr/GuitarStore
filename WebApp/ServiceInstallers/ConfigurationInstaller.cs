using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Schedule.Configuration;
using WebApp.ServiceInstallers.Abstractions;

namespace Schedule.ServiceInstallers
{
    public class ConfigurationInstaller: IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
        {
            services
                .Configure<AuthConfiguration>(configuration.GetSection("Auth"))
                .Configure<CaptchaConfiguration>(configuration.GetSection("ReCaptcha"));
        }
    }
}