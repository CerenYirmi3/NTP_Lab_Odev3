using System;

namespace NTP_4.Hafta_2.Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(dizi[i, j] + ", ");
                }
            }

            Console.ReadLine();
        }
    }
}