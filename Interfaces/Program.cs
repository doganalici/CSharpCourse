using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = {new SqlServerCustomerDal(),new OracleServerCustomerDal(),new MySqlCustomerDal()};
            foreach (var customerDal in customerDals)
                customerDal.Add();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer1 = new Customer();
            {
                customer1.Id = 1;
                customer1.FirstName = "Engin";
                customer1.LastName = "Demiroğ";
                customer1.Adress = "Ankara";
            }
            Student student1 = new Student();
            {
                student1.Id = 2;
                student1.FirstName = "Derin";
                student1.LastName = "Demiroğ";
                student1.Departmans = "Computer Sciences";
            }
            Worker worker1 = new Worker();
            worker1.Id = 3;
            worker1.FirstName = "Doğan";
            worker1.LastName = "Alıcı";
            worker1.Departmans = "Computer Engineer";

            manager.Add(customer1);
            manager.Add(student1);
            manager.Add(worker1);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmans { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmans { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            string className = person.GetType().Name;

            Console.WriteLine($"{className} Id : {person.Id}");
            Console.WriteLine($"{className} First Name : {person.FirstName}");
            Console.WriteLine($"{className} First Name : {person.LastName}");

            if (person is Student student)
            {
                Console.WriteLine($"{className} Departmans : {student.Departmans}\n\n***************************************\n");
            }
            else if (person is Worker worker)
            {
                Console.WriteLine($"{className} Departmans : {worker.Departmans}\n\n***************************************\n");
            }
            else if (person is Customer customer)
            {
                Console.WriteLine($"{className} Departmans : {customer.Adress}\n\n***************************************\n");
            }
        }
    }
}
