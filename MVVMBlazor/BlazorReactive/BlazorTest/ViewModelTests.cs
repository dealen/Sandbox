using BlazorReactive.ViewModels;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest
{
    public class ViewModelTests
    {
        private IInfoViewModel _infoViewModel;

        [SetUp]
        public void Setup()
        {
            _infoViewModel = A.Fake<IInfoViewModel>();
        }

        [Test]
        public async Task CanInitializeViewModel()
        {
            await _infoViewModel.InitViewModel();

            _infoViewModel.People.Should().NotBeNull();
            _infoViewModel.People.Count.Should().BeGreaterThanOrEqualTo(0);
        }

        [Test]
        public async Task CanAddPeopleToPersonList()
        {
            await _infoViewModel.InitViewModel();

            var person = new BlazorReactive.Models.Person { FirstName = "Kuba", LastName = "M", Id = 123213 };
            await _infoViewModel.AddPerson(person);

            _infoViewModel.People.Should().NotBeNull();
            _infoViewModel.People.Count.Should().BeGreaterThanOrEqualTo(0);
        }
    }
}
