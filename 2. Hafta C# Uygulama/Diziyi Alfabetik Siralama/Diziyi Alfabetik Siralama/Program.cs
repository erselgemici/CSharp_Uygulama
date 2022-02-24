using System;

namespace Diziyi_Alfabetik_Siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen veri adedini giriniz : ");
            int adet;
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen en sevdiğiniz {0} adet filmi giriniz. ", adet);

            string[] film = new string[adet];

            string TvSeries;
            for (int i = 0; i < adet; i++)
            {
                Console.Write(i + 1 + ". filmi giriniz : ");
                TvSeries = Console.ReadLine();
                film[i] = TvSeries;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Girdiğiniz filmlerin alfabetik sıralanışı şu şekildedir:");
            Array.Sort(film);
            foreach (string eleman in film)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadKey();
        }
    }
}
