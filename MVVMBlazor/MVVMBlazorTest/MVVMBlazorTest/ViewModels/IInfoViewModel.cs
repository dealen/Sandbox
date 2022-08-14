using MVVMBlazorTest.Models;
using System.Collections.ObjectModel;

namespace MVVMBlazorTest.ViewModels
{
    public interface IInfoViewModel
    {
        bool IsBusy { get; set; }
        Person Person { get; set; }
        ObservableCollection<Person> People { get; set; }
        void OnAddPerson(Person person);
    }
}
