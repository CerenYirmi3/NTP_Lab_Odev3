using System;

namespace NTP_4.Hafta_11.Ornek
{
    class Metotlar
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }

        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void Main(string[] args)
        {
            Metot1('f', 'g');
            Console.ReadKey();
        }
    }
}

