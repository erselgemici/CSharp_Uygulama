using System;

namespace Iki_Sayinin_Toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2,toplam;

            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("{0} ve {1} sayısının toplamı : {2}",sayi1,sayi2,toplam);

            Console.ReadKey();

        }
    }
}
