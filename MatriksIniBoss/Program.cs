using System;

namespace IniMatriks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Dimensi Matriks\n :");
            int n=Convert.ToInt32(Console.ReadLine());
           int[,] satu = new int[n,n];

            Random r = new Random();
            for (int i = 0; i < satu.GetLength(0); i++)
            {
                for (int j = 0; j < satu.GetLength(1); j++)
                {
                    satu[i, j] = r.Next(0, 30);
                }
            }

            for (int i = 0; i < satu.GetLength(0); i++)
            {
                for (int j = 0; j < satu.GetLength(1); j++)
                {
                    Console.Write($"{ satu[i, j]}\t");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}