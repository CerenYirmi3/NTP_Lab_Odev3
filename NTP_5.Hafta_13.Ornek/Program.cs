using System;

namespace NTP_5.Hafta_13.Ornek
{
    class Toplama
    {
        public int X;
        public int Y;
        public Toplama(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Toplama() : this(-1, -1) { }
        public Toplama(int x) : this(x, 1) { }
        public int Islem()
        {
            return X + Y;
        }
        public void Yaz()
        {
            Console.WriteLine("× = {0}", X);
            Console.WriteLine("Y = {0}", Y);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Toplama t = new Toplama(5, 6);
            t.Yaz();
            Toplama y = new Toplama();
            y.Yaz();
            Toplama u = new Toplama(7);
            u.Yaz();
        }
    }
}
