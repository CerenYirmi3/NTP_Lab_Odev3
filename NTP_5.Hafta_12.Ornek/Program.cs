using System;

namespace NTP_5.Hafta_12.Ornek
{
    class Program
    {
        public int tpl;
        public static int Topla(int toplam)
        {
            int tpl = toplam;
            return tpl;
        }
        public int Toplama
        {
            get { return tpl; }
            set { tpl = value + tpl; }
        }
        static void Main(string[] args)
        {
            Program ekle = new Program();
            Console.WriteLine("Başlangıç değeri->" + ekle.Toplama);
            for (int i = 1; i < 100; i++) ekle.Toplama = i;
            Console.WriteLine("Sayıların toplamı" + ekle.Toplama);
            Console.ReadLine();
        }
    }
}
