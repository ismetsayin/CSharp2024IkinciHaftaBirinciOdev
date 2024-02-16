using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Toplama(19);
            //Console.WriteLine(result);

            Console.WriteLine(Carpma(2, 4));
            Console.WriteLine(Carpma(2, 4,5));
            Console.WriteLine(BirdenFazlaSayiyiToplamaParams(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Toplama(int number1 , int number2=99)
        {
            var result = number1 + number2;
            return result;
        }

        static int Carpma(int number1 , int number2)
        {
            return number1 * number2;
        }

        static int Carpma(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int BirdenFazlaSayiyiToplamaParams(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
