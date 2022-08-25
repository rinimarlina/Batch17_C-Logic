using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_day01
{
    internal class QuizLogic_01
    {
        //No 1. Buat program untuk menghitung summary dari angka yang diinput
        public static void Summary()
        {
            int sum = 0;
            int x;
            Console.Write("Enter number integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                x = n % 10;
                sum = sum + x;
                n = n / 10;
            }
            Console.Write("Total sum= " + sum);
        }

        //2. Buat program untuk menghitung jumlah digit yang diinput. Tidak dibolehkan menggunakan string.length().
        public static void CountDigits()
        {
            int sum = 0;
            int x = 0;
            Console.Write("Enter number integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
                x++;

            }

            Console.WriteLine($"Count= {x}");
        }

        //No 3. Buat program dengan inputan integer dan output (balik angka)
        public static void BalikAngka()
        {
            Console.Write("Enter number integer: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;
            while (angka != 0 )
            {
                hasil = angka % 10;
                angka = angka / 10;

                Console.Write($"{hasil}");
            }
        }

        //No 4. Buat program untuk menampilkan bilangan terbesar kedua dengan inputan dinamis.Tidak dibolehkan angka inputan dikurang 1.
        public static void MaxKedua()
        {
            int count = 0;
            Console.Write("Enter number integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                count++;
            }
            Console.Write($"Count = {count}");
        }

        //No 5. Buat program GuessNumber, dimana user input angka untuk menebak random number, jika benar munculkan return message
        public static void GuessNumbers()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter your guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                // cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"Tebakan kamu benar, angka yang ditebak {guess}");
                    Console.WriteLine($"Tebak lagi?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("\n");
                        GuessNumbers();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Quit");
                        break;
                    }
                }
                else if (
                    guess > number)
                {
                    Console.WriteLine($"Your guess is too high");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low");
                }


            }
        }

        //No 6.Buat program menampilkan angka terbesar
        public static void Max()
        {
            int max = int.MinValue;
            int number;
            int x;


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter number integer: [Ketik 0 untuk keluar]");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                else if (number == 0)
                {
                    Console.Write($"Angka terbesar: {max}");
                    break;
                }
            }
        }

        //No 7.Buat program untuk menampilkan angka pembagi dari sebuah bilangan
        public static void AngkaPembagi()
        {
            Console.Write("Enter number :");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //No 8.Buat program untuk menampilkan bilangan prima dalam range tertentu.
        public static void PrimeNumber()
        {
            Console.Write("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                int jumlah = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        jumlah++;
                    }
                }
                if (jumlah == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //No 9. 
        //10.Buat program untuk menghitung jumlah huruf vocal dan consonant dalam sebuah kalimat


        //No 10.
    }
}
