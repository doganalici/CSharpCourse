using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id { get; set; }
        public void Save()
        {
            int id;
        }
        public void Delete()
        {

        }
    }
    class Student : Customer
    {
        public void Save2()
        {

        }
    }
    internal class Course //internal classı bağlı olduğu proje içinde referans ihtiyacı olmadan kullanılabilir
    {
        public string Name { get; set; }
    }
    public class Course2 //referans verildiği zaman herhangi bir projede de kullanılabilir
    {
        public string Name { get; set; }
    }
}
