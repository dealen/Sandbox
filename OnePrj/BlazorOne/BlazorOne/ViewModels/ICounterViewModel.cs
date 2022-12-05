using BlazorOne.Data;
using Microsoft.AspNetCore.Components.Forms;
using ReactiveUI;
using System.Windows.Input;

namespace BlazorOne.ViewModels
{
    public interface ICounterViewModel : IReactiveObject
    {
        int CurrentCount { get; set; }

        ICommand IncrementCounter { get; }

        ICommand SubmitForm { get; }

        public string FormResults { get; set; }

        EditContext Context { get; set; }

        FormExampleModel Model { get; set; }
    }
}
