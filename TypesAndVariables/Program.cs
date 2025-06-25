using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            int number1 = 2147483647;
            long number2 = 2147483647845484814;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.4;
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine($"Number1 is {number1}");
            Console.WriteLine($"Number2 is {number2}");
            Console.WriteLine($"Number3 is {number3}");
            Console.WriteLine($"Number4 is {number4}");
            Console.WriteLine($"Bool is {condition}");
            Console.WriteLine($"Char is {(int)character}");
            Console.WriteLine($"Char is {character}");
            Console.WriteLine($"String is {city}");
            Console.WriteLine($"Number5 is {number5}");
            Console.WriteLine($"Number6 is {number6}");
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine($"Number7 is {number7}");
        }
        enum Days
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }


    }
}
