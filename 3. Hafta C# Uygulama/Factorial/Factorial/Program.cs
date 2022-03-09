using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.Write("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Faktöriyel Sonucu : {0}",factorial);

            Console.ReadLine();
        }
    }
}
