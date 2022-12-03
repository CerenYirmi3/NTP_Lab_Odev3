using System;

namespace NTP_9.Hafta_13.Ornek
{
    class A
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class B : A
    {
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }
    class Ana
    {
        class Program
        {
            static void Main(string[] args)
            {
                B b = new B();
                b.Metot1();
                Console.ReadLine();
            }
        }
    }
}
