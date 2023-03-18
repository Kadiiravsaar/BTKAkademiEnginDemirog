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

            int number1 = 20;
            int number2 = 100;
            var result = Add(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1); // 20 yazar çünkü bizim değer(value) tiplerimizde veri ile ilgilenir isim ile değil

            Console.WriteLine("*****************");
            int n1 = 20;
            int n2 = 100;
            var result2 = Add2(ref n1, n2);// ref kullanmamızın amacı artık değer değil referans tip olsun ve metotda 
            // tanımlanan referans ile eş değer olsun
            Console.WriteLine(result2);
            Console.WriteLine(n2);


            Console.Read();
        }

        static int Add(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}