using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program //bizim yapmak istediğimiz işlemleri gruplara ayırmak, o grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için classları en temel olarak tanımlayabiliriz
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.WriteLine("-----------------");
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.WriteLine("******************\n");

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.City = "Ankara";

            Customer customer2 = new Customer { Id = 2, FirstName = "Doğan", LastName = "Alıcı", City = "Malatya" };

            Console.WriteLine(customer2.FirstName);
        }
    }

    //class CustomerManager -> müşteriyle ilgili işlemleri koyuyoruz
    //{

    //}

    //class ProductManager
    //{

    //}
}
