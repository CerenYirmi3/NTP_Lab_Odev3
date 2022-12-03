using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hafta_Lab_2.Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("İlk matrisin satırsayısını giriniz:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İlk matrisin sütun sayısını giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matris1 = new int[a, b];

            MatrisAlim(matris1);

            Console.Write("İkinci matrisin satırsayısını giriniz:  ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci matrisin sütun sayısını giriniz: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] matris2 = new int[c, d];

            MatrisAlim(matris2);

            MatrisCarpim(matris1,matris2);

            Console.ReadLine();
        }

        static void MatrisAlim(int[,] matris)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write("[{0}] [{1}] : " ,i,j);
                    matris[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(); ;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void MatrisCarpim(int[,] dizi1, int[,] dizi2)
        {
            int[,] dizi3 = new int[dizi1.GetLength(0), dizi2.GetLength(1)];

            for (int x = 0; x < dizi1.GetLength(0); x++)
            {
                for (int y = 0; y < dizi2.GetLength(1); y++)
                {
                    for (int z = 0; z < dizi2.GetLength(0); z++)
                    {
                        dizi3[x, y] += dizi1[x, z] * dizi2[z, y];  
                    }

                }
            }

            for (int i = 0; i < dizi3.GetLength(0); i++)
            {
                for (int j = 0; j < dizi3.GetLength(1); j++)
                {
                    Console.Write(dizi3[i,j] + "  ");
                }
                Console.WriteLine();
            }

        }



    }
}
