﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class ArraysCase
    {
        public static void IntroArray()
        {
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 45;
            arrInt[3] = 50;
            arrInt[4] = 1_000_000;
            //arrInt[4] = 90;

            string[] listOfGirl = new string[] { "Yuli", "Rini", "Widi" }; 
            //display array
            foreach (var item in listOfGirl)
            {
                Console.WriteLine($"{item}");
            }

            for (int i = 0; i < listOfGirl.Length; i++)
            {
                Console.WriteLine(listOfGirl[i]);
            }
        }


        //method return or function input array int, return array int

        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }

            return arr;
        }

        //sum all array element
        public static double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}");
            }
        }
        
        

    }
}

