using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>() { new Customer
                {
                FirstName = "Engin",
                LastName = "Demiroğ",
                City = "Ankara"
                },
                new Student
                {
                    FirstName = "Derin"
                },
                new Person {
                    FirstName = "Salih"
                }
               };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }

}
