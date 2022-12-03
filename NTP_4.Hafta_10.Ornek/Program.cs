using System;

namespace NTP_4.Hafta_10.Ornek
{
    class Metotlar
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }

        static void Metot1(double x, double y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void Main(string[] args)
        {
            Metot1(5, 6);

            Console.ReadKey();
        }
    }
}
