using System;

namespace NTP_4.Hafta_1.Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dizi = new int[20];
            char[] chr = new char[20];

            for (int i = 0; i < 20; i++)
            {
                dizi[i] = r.Next(1, 51);
                chr[i] = (char)r.Next(20, 126);

            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("\n{0,2}. deger {1,2} ->", i, dizi[i]);
                for (int j = 0; j < dizi[i]; j++)
                {
                    Console.Write(chr[i]);
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
