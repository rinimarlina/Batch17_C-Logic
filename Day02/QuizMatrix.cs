using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class QuizMatrix
    {
        //09
        public static int[,] No9(int b, int k)
        {
            int[,] matrix = new int[b, k];
            int counter = 5;

            //fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            return matrix;
        }

        //10
        public static int[,] No10(int b, int k)
        {
            int[,] matrix = new int[b, k];
            Random r = new Random();
            double sum = 0;

            //fill matrix
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //isi diagonal
                    matrix[i, j] = r.Next(100);
                    if (i == j)
                    {
                        sum += matrix[i ,j];

                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }

                }
            }
            Console.WriteLine($"Total sum Random = {sum} ");
            return matrix;
        }

        //No.11

        public static int[,] No11(int baris, int kolom)
        {
            int[,] matrix = new int[7, 7];
            int n = baris - 1;
            
            //fill matrix

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
                
            }
            return matrix;
        }

        //No. 12
        //public static int[,] HitungMatrix(int b, int k)
        //{
        //    int[,] matrix = new int[7, 7];
        //    //int temp = matrix[i, j];
        //    int summ = 0;
        //    //matrix[6, 6] = 0;

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            foreach ( in matrix)
        //            {
        //                summ += ;
        //                int temp = matrix[i, j];
        //                //summ += matrix[i, j];
        //                temp = summ;

        //                if (i == j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }
        //                else if (i < j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }
        //                else if (i > j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }

        //            }
        //        }
        //    }

        //    return matrix;
        //}

        //No.14
        //public static int[,] No14(int baris, int kolom)
        //{
        //    int[,] matrix = new int[7, 7];
        //    int n = baris - 1;

        //    //fill matrix

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {

        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            matrix[i, j] = i + j;
        //            if (i != 0 && j != 0)
        //            {
        //                if (i != n && j != n)
        //                {
        //                    matrix[i, j] = 0;
        //                }
        //            }
        //        }

        //    }
        //    return matrix;
        //}

        //No 15


        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //looping kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
