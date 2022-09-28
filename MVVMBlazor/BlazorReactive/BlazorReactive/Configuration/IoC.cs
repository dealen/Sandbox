using BlazorReactive.Data;
using BlazorReactive.Utilities;
using BlazorReactive.ViewModels;

namespace BlazorReactive.Configuration
{
    internal static class IoC
    {
        internal static void ConfigureIoC(this IServiceCollection services)
        {
            //services.AddSingleton<ViewModelManager>();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<IInfoViewModel, InfoViewModel>();
            services.AddTransient<InfoViewModel, InfoViewModel>();
            services.AddTransient<ILoginViewModel, LoginViewModel>();
            services.AddTransient<LoginViewModel, LoginViewModel>();
        }
    }
}
