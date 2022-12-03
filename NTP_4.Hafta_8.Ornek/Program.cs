using System;

namespace NTP_4.Hafta_8.Ornek
{
    class metotlar_diziparametre
    {
        static void DiziYaz(int[] a, int Sekil)
        {
            if (Sekil == 0)
            {
                foreach (Object o in a)
                    Console.Write(o.ToString() + " ");
                Console.WriteLine();
            }
            else if (Sekil == 1)
            {
                int x = 1;
                foreach (Object o in a)
                {
                    Console.Write("{0,5}", o.ToString());
                    if (x % 3 == 0)
                        Console.WriteLine();
                    x++;
                }
            }
            else
            {
                foreach (Object o in a)
                    Console.WriteLine(o.ToString());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DiziYaz(dizi, 0);
            DiziYaz(dizi, 1);
            DiziYaz(dizi, 2);

            Console.ReadKey();
        }
    }
}
