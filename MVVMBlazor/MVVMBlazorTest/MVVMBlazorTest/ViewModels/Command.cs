using System.Windows.Input;

namespace MVVMBlazorTest.ViewModels
{
    public class Command : ICommand, IDisposable
    {
        public event EventHandler CanExecuteChanged;

        private Func<bool> canExecuteFunc;
        private Action executeAction;
        private Action<object> execute;

        public Command(Action executeAction) : this(executeAction, () => true)
        {
        }

        public Command(Action executeAction, Func<bool> canExecuteFunc)
        {
            this.executeAction = executeAction;
            this.canExecuteFunc = canExecuteFunc;
        }

        public Command(Action<object> execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecuteFunc();
        }

        public void Dispose()
        {
            RemoveAllEvents();
        }

        public void Execute(object parameter)
        {
            executeAction();
        }

        public void RemoveAllEvents()
        {
            CanExecuteChanged = null;
        }


    }
}
