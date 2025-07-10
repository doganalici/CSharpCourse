using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //public string FirstName;  --> Field (bir değişken, bir alan tanımlamak)


        public int Id { get; set; }  // -> Property (bir özellik tanımlamak)

        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mr." + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
// bir class içinde bir özellik tanımlayacaksak classın özelliklerini belirten; bu gibi durumda property tanımlanır