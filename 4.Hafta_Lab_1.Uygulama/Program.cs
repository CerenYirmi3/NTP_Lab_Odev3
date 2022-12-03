using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hafta1.Uygulama
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            DiziTanimla(sayilar);
            DiziYazdır(sayilar);
            IndeksSecme(sayilar);

            Console.ReadLine(); 
        }


        static void DiziTanimla(int[] tani)
        {  

            for (int i = 0; i < tani.Length; i++)
            {
                Console.Write((i+1) + ". dizi elemanını giriniz: ");
                tani[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
        }

        static void DiziYazdır(int[] yaz)
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("Dizinin {0}. elemanı: " + yaz[i] ,(i+1));
            }

            Console.WriteLine();
        }

        static void IndeksSecme(int[] sec)
        {
            Console.Write("Dizi içerisinde görmek istediniz elemanın sırasını yazınız: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dizinin {0}. elemanı: " + sec[i-1] ,i);
        }
      
    }
}
