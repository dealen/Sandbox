using BlazorOne.Data;
using Microsoft.AspNetCore.Components.Forms;
using ReactiveUI;
using System.Windows.Input;

namespace BlazorOne.ViewModels
{
    public class CounterViewModel : ReactiveObject, ICounterViewModel
    {
        public CounterViewModel()
        {
            IncrementCounter = ReactiveCommand.Create(Increment);
            SubmitForm = ReactiveCommand.Create<FormExampleModel>(Submit);
            Model = new FormExampleModel();
            Context = new EditContext(Model);
        }

        private int _currentCount;

        public int CurrentCount
        {
            get { return _currentCount; }
            set { _currentCount = value; }
        }

        public FormExampleModel Model { get; set; }
        public ICommand IncrementCounter { get; }
        public ICommand SubmitForm { get; }
        public string FormResults { get; set; }
        public EditContext Context { get; set; }

        private void Increment()
        {
            CurrentCount++;
        }

        private void Submit(FormExampleModel model)
        {
            if (model != null &&
                !string.IsNullOrWhiteSpace(model.FirstName) &&
                !string.IsNullOrWhiteSpace(model.LastName))
            {
                FormResults = $"{model.FirstName} {model.LastName} {model.Age}";
            }
        }
    }
}
