using System;

namespace DizideArama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strDizi = { "Ejder", "Beratiye", "Melike", "Ersel" };
            Console.Write("Bir kelime giriniz : ");
            string kelime = Console.ReadLine();
            if (ara(strDizi, kelime))
                Console.WriteLine(kelime + " dizide bulundu.");
            else
                Console.WriteLine(kelime + " dizide bulunamadı.");
            
        }
        public static bool ara(string[] dizi, string aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
                if (aranan.Equals(dizi[i])) return true;
            return false;
        }
    }
    
}
