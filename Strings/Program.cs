using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Doğan Alıcı";
            var result = sentence.Length; //Length Kaç karakterden oluştuğunu gösterir
                                          //Console.WriteLine(result);

            var result2 = sentence.Clone();
            //sentence = "Engin Demiroğ"; //sentence klonlandığı için bu alanda değiştirsek de değişmeyecektir
            //Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("ı"); //bu cümle içindeki yazan ile bitiyor mu diye bool döndürür
            bool result4 = sentence.EndsWith("My name"); //bu cümle içindeki yazan ile başlıyor mu diye bool döndürür

            var result5 = sentence.IndexOf("name");//belli bir stringde belli bir karakterteri yada ifadeyi aramak için kullanılır
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//aramaya baştan değil de sondan başlar
            var result8 = sentence.Insert(0, "Hello, ");//bir cümleye veya bir string ifadeye başka bir metni yerleştirmek için kullanılır
            var result9 = sentence.Substring(3, 8);//metni parçalamak için kullanılır. yani belli bir yerinden itibaren almaktır
            var result10=sentence.ToLower();//bütün karakterleri küçük harfe çevirir
            var result11 = sentence.ToUpper();//bütün karakterleri büyük harfe çevirir
            var result12 = sentence.Replace(" ","-");//bir metin içinde belli karakterleri değiştirmek için kullanılır
            var result13 = sentence.Remove(7,3);//bir metinden belli bir indexten sonrasını atmak için kullanılır
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
