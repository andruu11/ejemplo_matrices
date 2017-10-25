using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca cantidad de filas y columnas:");
            int x = Convert.ToInt32(Console.ReadLine());

            int[,] matrizb = new int[x,x];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i == j)
                    {
                        matrizb[i, j] = 1;
                    }
                    else
                    {
                        matrizb[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < x; j++)
                {
                    Console.Write(matrizb[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
