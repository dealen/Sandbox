using ReactiveUI.Blazor;
using System.ComponentModel;

namespace BlazorBlog.Pages
{
    public class PageBase<T> : ReactiveComponentBase<T>
        where T : class, INotifyPropertyChanged
    {
        public PageBase()
        {
        }

        protected override async Task OnInitializedAsync()
        {

            await base.OnInitializedAsync();
        }
    }
}
