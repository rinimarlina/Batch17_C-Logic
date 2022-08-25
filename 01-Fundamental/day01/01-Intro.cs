namespace day01
{
    class Intro
    {
        public static void ShowConsole()
        {
            Console.WriteLine("Hello, World!");

            //1. output show normal test
            Console.WriteLine("CodeId Bootcamp");

            //2.concat
            Console.WriteLine("Code Academy" + "Bootcamp NET");

            //3.
            Console.WriteLine("Code Academy \nCool .NET");

            //4
            Console.WriteLine("I Love Programming \"C#\"");

            //5
            Console.WriteLine("Greek alphabet for B : \u03B2");

            //6
            Console.WriteLine("C:\\bootcamp\\BATCH14\\DotNet\\01-Fundamental\\");

            //7 verbatim
            Console.WriteLine(@"Bootcamp .NET with CodeID Academy
Location Sentul City
Bogor"); //simbol @ menjadikan text otomatis ke bawah

            //8
            Console.WriteLine(
                    @"Which best programming language')
=============================
");
            Console.WriteLine("a) java");
            Console.WriteLine("b) c#");
            Console.WriteLine("c) golang");

            //9 formatted number
            Console.WriteLine("Temperatur on {0:D} is {1}C", DateTime.Today, 36.5);
        }

    }
}