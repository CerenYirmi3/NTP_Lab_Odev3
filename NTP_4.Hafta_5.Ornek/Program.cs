using System;

namespace NTP_4.Hafta_5.Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim= ");

            string aranan = Console.ReadLine();
            foreach (string ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu...");

                else
                {
                    Console.WriteLine("isim yok");
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
