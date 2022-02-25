using System;

namespace Sayilarin_Toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz : ", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı : {0}", toplam);
            Console.ReadKey();
        }
    }
}
