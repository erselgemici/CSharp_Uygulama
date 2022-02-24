using System;

namespace _1_N_arasi_3e_ve_7ye_Tam_Bolunen_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : "); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 1 ; i < n; i++)

            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
