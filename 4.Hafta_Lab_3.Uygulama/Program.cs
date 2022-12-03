using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hafta_Lab_3.Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Rastgele kaç edet sayı üretilsin? ");
            int miktar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] pozitif = new int[miktar];
            int[] negatif = new int[miktar];
            int[] tum = new int[miktar];
            int sayi;
            int sifir = 0;
            for (int i = 0; i < miktar; i++)
            {
                sayi = random.Next(-101,101);

                if (sayi>0)
                {
                    pozitif[i] = sayi;
                }
                else if (sayi<0)
                {
                    negatif[i] = sayi;
                }
                else
                {
                    sifir += 1;
                }

                tum[i] = sayi;

            }

            Console.WriteLine("Tüm sayılar:");

            foreach (int t in tum)
            {
                Console.Write(t + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Pozitif sayılar:");

            foreach (int p in pozitif)
            {
                if (p != 0)
                {
                    Console.Write(p + ", ");
                }
                else
                {}
            }

            Console.WriteLine("\n");
            Console.WriteLine("Negatif sayılar:");

            foreach (int n in negatif)
            {
                if (n != 0)
                {
                    Console.Write(n + ", ");
                }
                else
                {}
                
            }

            Console.WriteLine("\n");
            Console.WriteLine(sifir + " adet sifir sayısı ortaya çıktı ve hiç bir gruba eklenmedi.");

            Console.ReadLine();
        }

    }
}
