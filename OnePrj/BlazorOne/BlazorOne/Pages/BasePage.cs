using Microsoft.AspNetCore.Components;
using ReactiveUI;
using ReactiveUI.Blazor;

namespace BlazorOne.Pages
{
    public class BasePage<T> : ReactiveComponentBase<T>
        where T : class, IReactiveObject
    {
        [Inject]
        public new T? ViewModel { get; set; }

        protected override Task OnInitializedAsync()
        {
            //ViewModel = Activator.CreateInstance<T>();

            return base.OnInitializedAsync();
        }
    }
}
