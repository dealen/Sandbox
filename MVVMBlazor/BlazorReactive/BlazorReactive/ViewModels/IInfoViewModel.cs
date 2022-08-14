using BlazorReactive.Models;
using System.Collections.ObjectModel;

namespace BlazorReactive.ViewModels
{
    public interface IInfoViewModel
    {
        string Message { get; set; }
        Person Person { get; set; }
        ObservableCollection<Person> People { get; set; }
        Task AddPerson(Person person);
        Task Initialize();
    }
}