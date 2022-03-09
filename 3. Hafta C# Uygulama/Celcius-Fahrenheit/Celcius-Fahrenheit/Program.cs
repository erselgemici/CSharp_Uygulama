using System;

namespace Celcius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            Console.Write("Derece cinsinden sıcaklık değerini giriniz : ");
            celcius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("{0}°C = {1}°F",celcius,fahrenheit);
            Console.ReadLine();
        }
    }
}
