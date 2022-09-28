using BlazorReactive.Utilities;
using BlazorReactive.ViewModels;
using BlazorReactive.ViewModels.Base;

namespace BlazorReactive.Pages
{
    public partial class InfoPage : BaseComponent<InfoViewModel>
    {
        public InfoPage()
        {

        }

        protected override async Task OnInitializedAsync()
        {
            //ViewModel = ViewModelManager.Create<IInfoViewModel>() as InfoViewModel;

            await base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            { 
                //await ViewModel.Initialize();
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        private void SubmitAddPerson()
        {
            ViewModel.AddPerson(ViewModel.Person);
        }
    }
}
