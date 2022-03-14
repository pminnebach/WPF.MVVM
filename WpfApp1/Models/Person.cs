using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp1.Models
{
    [ObservableObject]
    public partial class Person
    {
        public Person()
        {

        }

        public Person(string? FirstName, string? LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string? firstName;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string? lastName;

        public string? FullName => $"{FirstName} {LastName}";
        public void ClearFields()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}