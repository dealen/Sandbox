using BlazorReactive.Data;
using BlazorReactive.ViewModels;

namespace BlazorReactive.Configuration
{
    internal static class IoC
    {
        internal static void ConfigureIoC(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<IInfoViewModel, InfoViewModel>();
            services.AddTransient<ILoginViewModel, LoginViewModel>();
        }
    }
}
