using System;

namespace Girilen_Sayi_Kadar_Metni_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir metin giriniz : ");
            string metin = Console.ReadLine();
            Console.WriteLine("Metin kaç defa yazdırılsın ?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i < sayi; i++)
            {
                Console.WriteLine(metin);
            }

            Console.ReadKey();
        }
    }
}
