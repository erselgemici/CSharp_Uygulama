using System;

namespace Vucut_Kitle_Indeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            //18.5 ve altı Düşük Kilolu
            //18.5 - 24.9 Normal Kilolu
            //25 - 29.9 Fazla Kilolu
            //30 - 40 Obez
            //40 ve üstü Aşırı Obez

            double kilo, boy, vki;

            Console.Write("Kilo : ");
            kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boy : ");
            boy = Convert.ToDouble(Console.ReadLine());

            vki = kilo / (boy * boy);
            Console.WriteLine("Vücut Kitle İndeksiniz : {0} ", vki);

            Console.WriteLine("----------------------------------------");

            if (vki<=18.5)
            {
                Console.WriteLine("Düşük Kilolu");
                Console.WriteLine("----------------------------------------");
                Console.Write("Zayıflık,bazı hastalıklar için risk oluşturan ve istenmeyen bir durumdur." + 
                    "Boyunuza uygun ağırlığa erişmeniz için yeterli ve dengeli beslenmeli, beslenme alışkanlıklarınızı geliştirmeye özen göstermelisiniz.");
            }
            if (vki>18.5 && vki<25)
            {
                Console.WriteLine("Normal Kilolu");
                Console.WriteLine("----------------------------------------");
                Console.Write("Yeterli ve dengeli beslenerek ve düzenli fiziksel aktivite yaparak bu ağırlığınızı korumaya özen gösteriniz.");
            }
            if (vki>=25 && vki<30)
            {
                Console.WriteLine("Fazla Kilolu");
                Console.WriteLine("----------------------------------------");
                Console.Write("Fazla kilolu olma durumu gerekli önlemler alınmadığı takdirde pek çok hastalık için risk faktörü olan obeziteye (şişmanlık) yol açar.");
            }
            if (vki>=30 && vki<40)
            {
                Console.WriteLine("Obez");
                Console.WriteLine("----------------------------------------");
                Console.Write("Şişmanlık,kalp-damar hastalıkları, diyabet, hipertansiyon v.b. kronik hastalıklar için risk faktörüdür. " +
                    "Bir sağlık kuruluşuna başvurarak hekim / diyetisyen kontrolünde zayıflayarak normal ağırlığa inmeniz sağlığınız açısından çok önemlidir." +
                    " Lütfen,sağlık kuruluşuna başvurunuz.");
            }
            if (vki>=40) 
            {
                Console.WriteLine("Aşırı Obez");
                Console.WriteLine("----------------------------------------");
                Console.Write(" Lütfen,sağlık kuruluşuna başvurunuz.");
            }
        }
    }
}
