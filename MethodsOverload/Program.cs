using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));


            Console.WriteLine(Add1(2, 4, 5, 6, 7));


            Console.ReadLine();
        }

        static int Multiply(int number1, int number2)
        {

            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // overload işlemi yapıldı aşırı yüklenme olayı gerçekleşti
        {
            return number1 * number2 * number3;
        }


        // Params ile çalışmak istenirse-------
        static int Add1(params int[] numbers)
        {

            return numbers.Sum();
        }

    }
}
