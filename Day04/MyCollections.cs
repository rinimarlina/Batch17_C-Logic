﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class MyCollections
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] {"X", "Y"});

            foreach (var item in alfabet)
            {
                Console.Write($"{item}");
            }
            //declare list<int>
            var numbers = new List<int>() { 2, 5, 7, 11, 13, 17, 19 };
            numbers.Add(23);
            numbers.Remove(13);
            numbers.RemoveAll(var => v >= 7);

            Console.WriteLine(numbers);

            //find element
            var a = numbers.Find(e => e < 10);
            var b = numbers.FindLast(e => e < 11);
            var c = numbers.FindAll(e => e <= 10);

            //find index element
            var d = numbers.FindIndex(e => e <= 11);
            var e = numbers.FindLast(e => e <= 11);
            var f = numbers.IndexOf(13);
            var g = numbers.BinarySearch(11);
            Console.WriteLine(a);
        }

        //last in first out
        public static void InitStack()
        {
            var numbers = new Stack<int> (new int[]){ 1, 2, 3 });
            numbers.Push(5);
            numbers.Push (17);

            //remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();
        }
        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                { 1, "C#" },
                { 2, "Java" },
                { 3, "Python" }
            };

            //add new element
            pl2.Add(4, "Golang");
            //pl2.Add(4, "SQL");
            pl2.TryAdd(4, "sql");

            pl2[4] = "SQL";

            Console.WriteLine();
        }

        public static void InitHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 8 };
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>(hs1);
            result1.IntersectWith(hs2); //inner join => 1,2

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); //union => 1,2,3,4,5,6,9

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); //5,6,9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); //3,4,5,6,9

            //convert hashset to list

            var myNumber = result4.ToList();

            Console.WriteLine();
        }

        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("asep");
            queue.Enqueue("budi");
            queue.Enqueue("charlie");

            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item}");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");
            Console.WriteLine($"Current Queue from front to back");

            foreach (var item in queue)
            {
                Console.Write($"{item}");
            }

            served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");

        }


        //return list<T>
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            return myList;
        }
       
    }


}
