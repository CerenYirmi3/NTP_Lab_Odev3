using System;

namespace NTP_4.Hafta_6.Ornek
{
    class metotler_3
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            int s1, s2;

            Console.WriteLine("1.sayıyı girin: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı girin: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = BuyukBul(s1, s2);

            Console.WriteLine("en büyük {0}'dir. ", enBuyuk);

            Console.ReadKey();

        }
    }
}

