using System;

namespace NTP_5.Hafta_6.Ornek
{
    class Dortgen
    {
        public static int En = 20;
        public static int Boy = 5;
        public static int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("**");
                Console.WriteLine("En:{0,5}", En);
                Console.WriteLine("Boy:{0,5}", Boy);
                Console.WriteLine("Alan:{0,5}", Alan());
                Console.WriteLine("**");
                Console.ReadLine();
            }
        }
    }
}