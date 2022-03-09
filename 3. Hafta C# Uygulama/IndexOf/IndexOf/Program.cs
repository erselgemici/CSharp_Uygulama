using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz : ");
            string metin = Console.ReadLine();
            int piece = metin.IndexOf(' ');
            Console.WriteLine(metin.Substring(0,piece));
            Console.ReadKey();
        }
    }
}
