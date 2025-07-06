using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";


            string[] students2 = {"Engin","Derin","Salih"};

            string[] students3 = new string[]{"Engin","Derin","Salih"};

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n***********\n");

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n***********\n");

            foreach (string student in students3)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n***********\n");

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("----------");
            }
        }
    }
}
