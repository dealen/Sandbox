using MauiTestApp.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiTestApp.ViewModels
{
    public class StartPageViewModel : ReactiveObject 
    {
        private string _title;
        private string _label;
        private string _input;
        private ObservableCollection<ChatModel> _charLog;
        private List<ChatModel> _chatLogList;

        public StartPageViewModel()
        {
            ProcessTextCommand = ReactiveCommand.Create<string>(ProcessText);
            _charLog = new ObservableCollection<ChatModel>();
        }

        public string Title
        {
            get { return _title; }
            set { this.RaiseAndSetIfChanged(ref _title, value); }
        }
        public string Input
        {
            get { return _input; }
            set { this.RaiseAndSetIfChanged(ref _input, value); }
        }

        public ObservableCollection<ChatModel> ChatLog
        {
            get { return _charLog; }
            set { this.RaiseAndSetIfChanged(ref _charLog, value); }
        }

        public ICommand ProcessTextCommand { get; }

        private void ProcessText(string input)
        {
            ChatLog.Add(new ChatModel(input));
        }
    }
}
