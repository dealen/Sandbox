using BlazorReactive.Utilities;
using BlazorReactive.ViewModels;
using BlazorReactive.ViewModels.Base;
using ReactiveUI.Blazor;

namespace BlazorReactive.Pages
{
    public partial class LoginPage : BaseComponent<LoginViewModel>
    {
        protected override async Task OnInitializedAsync()
        {
            //ViewModel = ViewModelManager.Create<ILoginViewModel>();

            await base.OnInitializedAsync();
        }


    }
}
