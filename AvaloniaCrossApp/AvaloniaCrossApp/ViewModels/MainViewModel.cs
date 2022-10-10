using DynamicData;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AvaloniaCrossApp.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private ObservableCollection<string> _names;
        private string _selectedName;

        public MainViewModel()
        {
            _names = new ObservableCollection<string>();
            _selectedName = string.Empty;

            _names.Add("One");
            _names.Add("Two");
            _names.Add("Three");
            _names.Add("Four");
            _names.Add("Five");
            _names.Add("Six");
            _names.Add("Seven");
            _names.Add("Eight");
            _names.Add("Nine");
        }

        public string Greeting => "Welcome to Avalonia!";

        public string SelectedName
        {
            get => _selectedName;
            set => this.RaiseAndSetIfChanged(ref _selectedName, value);
        }

        public ObservableCollection<string> Names
        {
            get => _names;
            set => this.RaiseAndSetIfChanged(ref _names, value);
        }

        public async Task InitializeAsync()
        {
            // initialize collection

            await Task.CompletedTask;
        }
    }
}
