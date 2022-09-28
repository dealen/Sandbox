using BlazorReactive.ViewModels.Base;
using ReactiveUI;

namespace BlazorReactive.ViewModels
{
    public class LoginViewModel : ReactiveObject, ILoginViewModel
    {
        public async Task InitViewModel()
        {
            await Task.CompletedTask;
        }
    }
}
