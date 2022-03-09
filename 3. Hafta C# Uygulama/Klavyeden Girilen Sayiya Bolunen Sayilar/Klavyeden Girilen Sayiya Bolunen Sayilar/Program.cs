using System;

namespace Klavyeden_Girilen_Sayiya_Bolunen_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            Console.Write("Bir sayı giriniz : ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} sayısının katları:",sayi);

            for (int i = 1; i <= 200; i++)
            {
                if (i % sayi == 0)
                {
                    Console.WriteLine(i);
                    adet++;
                }
            }

            Console.WriteLine("1'den 200'e {0} sayısına bölünen {1} adet sayı vardır.",sayi,adet);
            Console.ReadLine();
        }
    }
}
