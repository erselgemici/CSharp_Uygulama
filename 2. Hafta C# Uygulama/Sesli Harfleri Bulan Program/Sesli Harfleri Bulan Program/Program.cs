using System;

namespace Sesli_Harfleri_Bulan_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Yıllar birer birer eskiyerek değiştiler. Oysa bir zamanlar çocuk gibi mahsun ve gençtiler.";
            string sesliHarf = "aeıioöuü";

            int sayac = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliHarf.Contains(metin[i]))
                {
                    sayac++;                    
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("Yukarıdaki metinde toplam {0} tane sesli harf vardır.", sayac);
            Console.ReadLine();
        }
    }
}
