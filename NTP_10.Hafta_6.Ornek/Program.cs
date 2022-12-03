using System;

namespace NTP_10.Hafta_6.Ornek
{
    delegate void OlayYoneticisi();
    class deneme
    {
        OlayYoneticisi[] evnt = new OlayYoneticisi[3];
        public int i = 0; public int j = 0;
        public event OlayYoneticisi Olay
        {
            add
            {
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    Console.WriteLine((i + 1) + ". Olay");
                }
                i++;
                if (i == 3)

                {
                    --i;
                    Console.WriteLine("Olay listesi Dolu");
                }

            }
            remove
            {
                Console.WriteLine(i);
                {
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        Console.WriteLine(" Olay çıkarıldı.");
                    }
                    i--;
                    if (i == -1)
                        Console.WriteLine("Olay bulunamadı");
                }
            }
        }

        public void Olayim()
        {
            for (int j = 0; j <= i; j++)
            {
                if (evnt[j] != null) evnt[j]();
            }
        }
    }
    class Program
    {
        static void Metot1()
        {
            Console.WriteLine("Metot1");
        }
        static void Metot2()
        {
            Console.WriteLine("Metot2");
        }
        static void Main()
        {
            deneme d = new deneme();
            d.Olay += new OlayYoneticisi(Metot1);
            d.Olay += new OlayYoneticisi(Metot2);
            d.Olay += new OlayYoneticisi(Metot1);
            d.Olayim();

            d.Olay -= new OlayYoneticisi(Metot1);
            d.Olay -= new OlayYoneticisi(Metot2);
            d.Olay -= new OlayYoneticisi(Metot1);
            d.Olayim();

            Console.ReadKey();
        }
    }

}
