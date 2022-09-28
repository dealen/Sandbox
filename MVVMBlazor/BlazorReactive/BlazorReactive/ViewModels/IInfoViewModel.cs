using BlazorReactive.Models;
using BlazorReactive.ViewModels.Base;
using System.Collections.ObjectModel;

namespace BlazorReactive.ViewModels
{
    public interface IInfoViewModel : IViewModel
    {
        string Message { get; set; }
        Person Person { get; set; }
        ObservableCollection<Person> People { get; set; }
        Task AddPerson(Person person);
        Task InitViewModel();
    }
}