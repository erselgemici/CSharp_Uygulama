using System;

namespace Asal_Sayi_Listeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            
            for (int i = 2; i <= 1000000; i++)
            {
                kontrol = 0;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    
                    Console.Write(i + "-");
                }

            }
            
            Console.ReadKey();
        }
    }
}
