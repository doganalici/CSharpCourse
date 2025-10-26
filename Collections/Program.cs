using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //Console.WriteLine(cities[2]);
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("***********");
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities.Contains("Adana"));
            Console.WriteLine("*************");
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });

            List<Customer> customers = new List<Customer> {
            new Customer { Id = 1, FirstName = "Engin" },
            new Customer { Id = 2, FirstName = "Derin" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4,FirstName="Ali" },
                new Customer { Id = 5,FirstName="Ayşe" }
             });
            customers.Add(customer2);
            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();
            var index = customers.IndexOf(customer2);
            Console.WriteLine($"Index : {index}");

            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine($"Last Index : {lastIndex}");

            customers.Insert(0, customer2);
            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine($"Count : {count}");
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
    }
}
