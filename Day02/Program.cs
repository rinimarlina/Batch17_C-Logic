using static System.Console;
using Day02;

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//ArraysCase.IntroArray();

////all function
//int[] n = { 10, 20, 30 };
//var myArray = ArraysCase.InitArrayInt(n);

//ArraysCase.DisplayArrayInt(myArray);
//var myRandom = ArraysCase.InitArrayRandom(20);

//WriteLine($"Total sum Random = {ArraysCase.SumAllElement(myRandom)}");
//WriteLine($"Max  = {ArraysCase.FindLargestElement(myRandom)}");


////copy array dari myrandom to new array
//int[] newArray = new int[5];
//for (int i = 0; i < newArray.Length; i++)
//{
//    newArray[i] = myRandom[i];
//}

//WriteLine();

////sort array
//Array.Sort(newArray);
//ArraysCase.DisplayArrayInt(newArray);

////gunakan method 
//var randomArray = new int[myRandom.Length];
//Array.Copy(newArray, 0, randomArray, 0, newArray.Length);
//Array.Reverse(newArray);
//ArraysCase.DisplayArrayInt(newArray);


/*WriteLine();
Array.Reverse(randomArray);
Array.Sort(randomArray); */


//QUIZ ARRAY//
//No. 01
//int[] n = { 15, 2, 30, 12, 10, 5 };
//var myArray = Day02.QuizDay02.InitArrayInt(n);
//Console.WriteLine("Before Random : ");
//Day02.QuizDay02.DisplayArray(myArray);
//var rini = Day02.QuizDay02.UbahPosisi(myArray);
//Console.WriteLine("\nAfter random position element change : ");
//Day02.QuizDay02.DisplayArray(rini);

//// No. 02
//int[] x = { 15, 2, 30, 12, 10, 5 };
//var myArray = Day02.QuizArray.InitArrayInt(x);
//Console.WriteLine("Before shifting : ");
//Day02.QuizArray.DisplayArray(myArray);
//var shift = Day02.QuizArray.ShiftArray(myArray);
//Console.WriteLine("\n After shifting : ");
//Day02.QuizArray.DisplayArray(shift);

//No 3
int[] n = { 15, 2, 30, 12, 10, 5 };
var RotateArray = Day02.QuizArray.InitArrayInt(n);
Console.WriteLine("\nBefore Rotating");
Day02.QuizArray.DisplayArray(RotateArray);
var num = QuizArray.RotateArray(RotateArray);

//No 5
//int[] x = { 15, 2, 30, 12, 10, 5, 2, 10, 5};
//var myArray = Day02.QuizArray.jumlahAngkaArray(x);
//var count = Day02.QuizArray.ShiftArray(myArray);



/*MATRIX*/
//Matrix.InitMatrix();
//var myMatrix = Matrix.FillRandomMatrix(5, 5);
//Matrix.DisplayMatrix(myMatrix);

//WriteLine();
//var matrixDiagonal = Matrix.MatrixDiagonal(5,5);
//Matrix.DisplayMatrix(matrixDiagonal);

/*QUIZ MATRIX*/
//09
//WriteLine();
//var matrixDiagonal = QuizMatrix.No9(5,5);
//Matrix.DisplayMatrix(matrixDiagonal);

//10
//WriteLine();
//var myDiagonal = QuizMatrix.No10(5, 5);
//Matrix.DisplayMatrix(myDiagonal);

//11
//WriteLine();
//var myDiagonal = QuizMatrix.No11(7, 7);
//Matrix.DisplayMatrix(myDiagonal);

//12
//WriteLine();
//var myHitung = QuizMatrix.HitungMatrix(6, 6);
//Matrix.DisplayMatrix(myHitung);

////No 15
//char[,] student = new char[,]{
//    {'A','B','A','C','C','D','E','E','A','D'},
//    {'D','B','A','B','C','A','E','E','A','D'},
//    {'E','D','D','A','C','B','E','E','A','D'},
//    {'C','B','A','E','D','C','E','E','A','D'},
//    {'A','B','D','C','C','D','E','E','A','D'},
//    {'B','B','E','C','C','D','E','E','A','D'},
//    {'B','B','A','C','C','D','E','E','A','D'},
//    {'E','B','E','C','C','D','E','E','A','D' },
//};
//char[] guru = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };





ReadLine();
