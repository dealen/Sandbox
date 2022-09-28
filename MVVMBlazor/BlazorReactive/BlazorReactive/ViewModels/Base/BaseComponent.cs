using Microsoft.AspNetCore.Components;
using ReactiveUI;
using ReactiveUI.Blazor;

namespace BlazorReactive.ViewModels.Base
{
    public class BaseComponent<T> : ReactiveComponentBase<T>
        where T : ReactiveObject
    {
        [Inject]
        public new T ViewModel
        {
#pragma warning disable CS8603 // Possible null reference return.
            get => base.ViewModel;
#pragma warning restore CS8603 // Possible null reference return.
            set => base.ViewModel = value;
        }

        protected override async Task OnInitializedAsync()
        {
            // derived class are using different interefaces to we can distinguish it by applying here 
            // some checks for that

            await BasicInitializationOfViewModels();

            await base.OnInitializedAsync();
        }

        private async Task BasicInitializationOfViewModels()
        {
            if (this.ViewModel is IViewModel viewModel)
            {
                await viewModel.InitViewModel();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await BasicInitializationOfViewModels();
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        protected override void Dispose(bool disposing)
        {
            // derived class are using different interefaces to we can distinguish it by applying here 
            // some checks for that

            base.Dispose(disposing);
        }
    }
}
