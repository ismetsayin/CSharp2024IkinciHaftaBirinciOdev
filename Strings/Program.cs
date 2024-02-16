using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is İsmet";

            var result = sentence.Length;       // Karakter uzunluğu
            var result2 = sentence.Clone();     // Kopyalama
            sentence = "My name is Ali";

            bool result3 = sentence.EndsWith("t");      // "t" ile mi bitiyor
            bool result4 = sentence.StartsWith("M");    // "M" ile mi başlıyor

            var result5 = sentence.IndexOf("Ali");      // aramaya baştan başlar
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf("y");    // aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, ");    // 0. indekse "Hello, " ekler
            var result9 = sentence.Substring(3, 4);    // Metni parçalamak için kullanılır
            var result10 = sentence.ToLower();    // Bütün karakterleri küçük harfe çevirir
            var result11 = sentence.ToUpper();    // Bütün karakterleri büyük harfe çevirir
            var result12 = sentence.Replace(" ", "-");    // Belirli karakterleri değiştirmek için kullanılır
            var result13 = sentence.Remove(2,5);    // 2'den sonrasını kaldır

            Console.WriteLine(result13);

            Console.ReadLine();
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

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
