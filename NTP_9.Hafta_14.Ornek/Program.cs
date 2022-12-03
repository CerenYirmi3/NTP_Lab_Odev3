using System;

namespace NTP_9.Hafta_14.Ornek
{
    class Program
    {
        class A
        {
            public int OzellikA;

            public A(int a)
            {
                OzellikA = a;
            }
        }
        class B : A
        {
            public int OzellikB;
            public B(int b, int a) : base(a)
            {
                OzellikB = b;
            }
        }
        class C : B
        {
            public int OzellikC;
            public C(int c, int b, int a) : base
            (b, a)
            {
                OzellikC = c;
            }
            static void Main(string[] args)
            {
                C nesne = new C(12, 56, 23);
                Console.WriteLine(nesne.OzellikA + "" + nesne.OzellikB + " " + nesne.OzellikC);
                Console.ReadLine();
            }
        }
    }
}
