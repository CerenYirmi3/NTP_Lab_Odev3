using System;

namespace NTP_10.Hafta_2_1.Ornek
{
    class deneme
    {
        static void Main()
        {
            for (; ; )
            {
                try
                {
                    Console.Write("Lütfen çıkmak için 0 ya da 1 girin: ");
                    string a = Console.ReadLine();
                    if (a == "0" || a == "1") break;
                    else
                    {
                        IndexOutOfRangeException nesne = new IndexOutOfRangeException("Başa dönüldü");
                        nesne.HelpLink = "http://tr.wikibooks.org/";
                        throw nesne;
                    }
                }
                catch (IndexOutOfRangeException nesne)
                {
                    Console.WriteLine(nesne.Message); continue;
                }
            }

            Console.ReadKey();
        }
    }
}
