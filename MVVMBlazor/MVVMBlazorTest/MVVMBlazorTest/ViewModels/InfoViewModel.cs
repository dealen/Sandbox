using MVVMBlazorTest.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMBlazorTest.ViewModels
{
    public class InfoViewModel : BaseViewModel, IInfoViewModel
    {
        private Person _person;
        private ObservableCollection<Person> _people;

        public InfoViewModel()
        {
            _people = new ObservableCollection<Person>();
            _person = new Person();
        }

        public void OnAddPerson(Person person)
        {
            People.Add(person);
            Person = new Person();
        }

        public Person Person { get => _person; set => Set(ref _person, value); }

        public ObservableCollection<Person> People 
        {
            get => _people;
            set => Set(ref _people, value);
        }
    }
}
