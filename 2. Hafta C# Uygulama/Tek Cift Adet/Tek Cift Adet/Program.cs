using System;

namespace Tek_Cift_Adet
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, tekSayisi = 0, ciftSayisi = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                sayi = rnd.Next();
                Console.WriteLine(sayi);
                if (sayi%2==0)
                {
                    ciftSayisi++;
                }
                else
                {
                    tekSayisi++;
                }
            }
            Console.WriteLine("Verilerin {0} adedi çifttir.", ciftSayisi);
            Console.WriteLine("Verilerin {0} adedi tektir.", tekSayisi);
            Console.ReadKey();
        }
    }
}
