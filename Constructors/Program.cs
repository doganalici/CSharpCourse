using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product { Id = 2, Name = "Computer" };
            Console.WriteLine("*********************");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            Console.WriteLine("*********************");

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Console.WriteLine("*********************");

            Teacher.Number = 10;


            Utilities.Validate();
            Console.WriteLine("*********************");

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine($"Listed! {_count} items");
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface Ilogger
    {
        void Log();
    }
    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        Ilogger _logger;
        public EmployeeManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine($"{_entity} message");
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
