using System;

namespace NTP_4.Hafta_9.Ornek
{
    class metorlar_5a
    {
        static void DegerTipAktarim(int Sayi)
        {
            Sayi = 30;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);

            DegerTipAktarim(x);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
