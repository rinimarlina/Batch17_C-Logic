using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class QuizDay02
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
        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");

            }
        }

        //No.2
        //public static int[] ShiftArray(int[] x)
        //{
        //    //local variable untuk return
        //    int[] arr = x;
        //    int[] temp =  int[.Length];
        //    for (int i - 1; i < arr.Length; i++)
        //    {
        //        arr[i - 1] = arr[i]; 
        //    }
        //    arr[arr.Length - 1] = temp;
        //    return arr;
        //}
    }
}
