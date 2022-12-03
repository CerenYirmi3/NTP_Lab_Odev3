using System;

namespace NTP_9.Hafta_16.Ornek
{
    interface IArayuz
    {
        int Metot1();
        void Metot2();
    }
    class Sinif : IArayuz
    {
        int IArayuz.Metot1()
        {
            Console.WriteLine("Metot1");
            return 0;
        }
        public void Metot2()
        {
            Console.WriteLine("Metot2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sinif s = new Sinif();
            IArayuz a;
            a = s;
            a.Metot1();
            Console.ReadLine();
        }
    }
}