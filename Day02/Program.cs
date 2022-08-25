using static System.Console;
using Day02;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ArraysCase.IntroArray();

//call function
int[] n = { 10, 20, 30 };
var myArray = ArraysCase.InitArrayInt(n);

ArraysCase.DisplayArrayInt(myArray);

var myRandom = ArraysCase.InitArrayRandom(20);

WriteLine($"Total sum Random = {ArraysCase.SumAllElement(myRandom)}");
WriteLine($"Max  = {ArraysCase.FindLargestElement(myRandom)}");

//copy array dari myrandom to new array
int[] newArray = new int[5];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}

WriteLine();

//sort array
Array.Sort(newArray);
ArraysCase.DisplayArrayInt(newArray);

//gunakan method 
var randomArray = new int[myRandom.Length];
Array.Copy(newArray, 0, randomArray, 0, newArray.Length);
Array.Reverse(newArray);
ArraysCase.DisplayArrayInt(newArray);

ReadLine();
