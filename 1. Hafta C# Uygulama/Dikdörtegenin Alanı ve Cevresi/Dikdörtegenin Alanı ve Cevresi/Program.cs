using System;

namespace Dikdörtegenin_Alanı_ve_Cevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisakenar, uzunkenar, alan, cevre;

            Console.Write("Kısa Kenar : ");
            kisakenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun Kenar : ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());

            alan = kisakenar * uzunkenar;
            Console.WriteLine("Alan : " + alan);

            cevre = 2*(kisakenar + uzunkenar);
            Console.Write("Çevre : " + cevre);
        }
    }
}
