using System;

namespace Girilen_sayi_0_100_arasi_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayıyı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0 && sayi < 100)
            {
                Console.WriteLine("Girilen sayı 0-100 aralığında");
            }
            else
            {
                Console.WriteLine("Girilen sayı 0-100 aralığında değil");
            }
        }
    }
}
