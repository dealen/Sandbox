using BlazorBlog.Data;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace BlazorBlog.Pages.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private ObservableCollection<Post> _posts;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IndexViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set { this.RaiseAndSetIfChanged(ref _posts, value); }
        }

        public override async Task InitializeViewModel()
        {
            _posts = new ObservableCollection<Post>();

            await base.InitializeViewModel();
        }
    }
}
