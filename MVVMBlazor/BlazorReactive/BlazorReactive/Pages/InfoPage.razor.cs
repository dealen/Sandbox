using Microsoft.AspNetCore.Components;

namespace BlazorReactive.Pages
{
    public partial class InfoPage : ComponentBase
    {
        public InfoPage()
        {

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            { 
                await ViewModel.Initialize();
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        private void SubmitAddPerson()
        {
            ViewModel.AddPerson(ViewModel.Person);
        }
    }
}
