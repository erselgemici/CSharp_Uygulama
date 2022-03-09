using System;

namespace Girilen_Sayiya_Gore_Islem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi,sonuc;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi%2==0)
            {
                sonuc = sayi / 2;
                Console.WriteLine("Girilen sayı çifttir.\n{0} / 2 = {1}",sayi,sonuc);
            }
            else
            {
                sonuc = sayi * 2;
                Console.WriteLine("Girilen sayı tektir.\n{0} * 2 = {1}",sayi,sonuc);
            }
            
            Console.ReadLine();
        }
    }
}
