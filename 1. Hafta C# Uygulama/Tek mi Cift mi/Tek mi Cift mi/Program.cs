using System;

namespace Tek_mi_Cift_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");

            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi + " sayısı çift sayıdır.");
            }
            else
            {
                Console.WriteLine(sayi + " sayısı tek sayıdır.");
            }
            
        }
    }
}
