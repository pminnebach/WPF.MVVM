using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    [ObservableObject]
    public partial class PersonViewModel
    {
        public PersonViewModel()
        {
            People = new ObservableCollection<Person>();
        }

        public Person Person { get; } = new Person();

        public ObservableCollection<Person> People { get; set; }

        [ICommand]
        public void Submit()
        {
#if DEBUG
            var _f = Person.FullName;
            Debug.WriteLine($"{_f} did something");
#endif
            if (!string.IsNullOrWhiteSpace(Person.FirstName) || !string.IsNullOrWhiteSpace(Person.LastName))
            {
                People.Add(new Person(Person.FirstName, Person.LastName));
                Person.ClearFields();
            }
        }
    }
}
