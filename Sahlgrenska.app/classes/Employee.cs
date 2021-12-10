using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahlgrenska.app.classes
{
    public class Employee
    {
        public Employee(
            int id, int socialSecurityNumber, string firstName, string lastName, string userName, string password, string title,
            int salary, string specialization, string email, int phoneNumber)
        {
            Id = id;
            SocialSecurityNumber = socialSecurityNumber;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Title = title;
            Salary = salary;
            Specialization = specialization;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        
    }
}
