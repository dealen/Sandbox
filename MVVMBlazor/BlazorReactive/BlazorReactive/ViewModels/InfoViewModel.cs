using BlazorReactive.Models;
using BlazorReactive.ViewModels.Base;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace BlazorReactive.ViewModels
{
    public class InfoViewModel : ReactiveObject, IInfoViewModel
    {
        private Person _person;
        private List<Person> _peopleList;
        private ObservableCollection<Person> _people;
        private string _message;

        public InfoViewModel()
        {
            _person = new Person();
            TimeInitialized = false;

            this.WhenAnyValue(x => x.People.Count)
            .Subscribe(x =>
            {
                if (People != null && People.Any())
                {
                    Message = $"Now there are {People.Count} people!";
                    TimeOfAddition = DateTime.Now;
                    TimeInitialized = true;
                }
            });

            Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Select(_ => DateTime.Now)
                .Throttle(TimeSpan.FromMilliseconds(500))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (TimeInitialized)
                    {
                        if (x > TimeOfAddition.AddSeconds(5))
                        {
                            var seconds = x - TimeOfAddition;
                            Message = $"No new people in {seconds.Seconds} seconds";
                        }
                    }
                });
        }

        public async Task InitViewModel()
        {
            _peopleList = new List<Person>();
            _people = new ObservableCollection<Person>(_peopleList);

            await Task.CompletedTask;
        }

        public string Message
        {
            get => _message;
            set => this.RaiseAndSetIfChanged(ref _message, value);
        }

        public DateTime TimeOfAddition { get; set; }
        public bool TimeInitialized { get; set; }

        public Person Person
        {
            get => _person;
            set => this.RaiseAndSetIfChanged(ref _person, value);
        }

        public ObservableCollection<Person> People
        {
            get => _people;
            set => this.RaiseAndSetIfChanged(ref _people, value);
        }

        public async Task AddPerson(Person person)
        {
            var perosonCopy = new Person 
            { 
                FirstName = person.FirstName,
                LastName = person.LastName,
                Id = person.Id
            };
            _peopleList.Add(perosonCopy);
            People = new ObservableCollection<Person>(_peopleList);
            person = new Person();

            await Task.CompletedTask;
        }
    }
}
