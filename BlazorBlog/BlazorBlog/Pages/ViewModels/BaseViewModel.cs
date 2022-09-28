using ReactiveUI;

namespace BlazorBlog.Pages.ViewModels
{
    public abstract class BaseViewModel : ReactiveObject
    {
        public virtual async Task InitializeViewModel()
        {


            await Task.CompletedTask;
        }
    }
}
