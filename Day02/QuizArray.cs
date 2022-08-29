using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class QuizArray
    {
        //No.1
        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }
        //cara 1 pakai while:
        //public static int[] UbahPosisi(int[] arr)
        //{
        //    int[] value = arr;
        //    Random rand = new Random();
        //    int n = arr.Length - 1;

        //    while (n > 0)
        //    {
        //        int temp = value[n];
        //        int random = rand.Next(0, n);
        //        value[n] = value[random];
        //        value[random] = temp;
        //        n--;
        //    }
        //    return arr;
        //}

        //cara 2 pakai for:
        public static int[] RandomPosition(int[] n)
        {
            int[] array = n;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0, n.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        //No. 2
        public static int[] ShiftArray(int[] arr)
        {
            int[] array = arr;
            int first = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                array[i] = arr[(i + 1)];
            }
            array[arr.Length - 1] = first;
            return array;
        }

        //No. 3
        public static int[] RotateArray(int[] arr)
        {
            int[] num = new int[arr.Length];
            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotating {j}");
                int first = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    num[i] = arr[(i + 1)];
                }
                num[arr.Length - 1] = first;
                DisplayArray(num);
                arr = num;
            }
            return num;
        }

        //No. 5
        public static int[] jumlahAngkaArray (int[] arr)
        {
            int[] array = arr;
            int count = 0;
            Array.Sort(array);
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (i < arr.Length - 1 && arr[i] != arr[i + 1] )
                {
                    Console.WriteLine($"{arr[i]} muncul sebanyak {count}  ");
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine($"{arr[i]} muncul sebanyak {count}  ");
                }
            }
            return array;

        }
        
        //No 7
        //public static int[] RemoveDuplicates(int[] n)
        //{
        //    int[] array = arr;

        //}


        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");

            }
        }

        
    }
}
