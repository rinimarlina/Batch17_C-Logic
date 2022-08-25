namespace day01
{
    class StoreVariable
    {
        //01
        public static void StoreCharText()
        {
            //store character
            char letter = 'A';
            char digit = '1';
            char symbol = '$';
            Console.WriteLine($"{letter} {digit} {symbol}");
        }

        //02 string
        public static void StoreString()
        {
            string firstName = "codeid";
            string lastName = "bootcamp";
            Console.WriteLine(firstName + "" + lastName);
        }

        //3 verbatim string
        public static void StoreVerbal()
        {
            //literal string
            string fullName = "Rini \tMarlina";

            string filePath = "c:\\bootcamp\\dotnet\\config.txt";

            //@ varbatim string : @ disable all escape characters so blackslash
            string filePath2 = @"c:\bootcamp\dotnet\config.json";

            Console.WriteLine($"{ fullName}");
        }
        //04 store integer float double
        public static void StoreNumber()
        {
            //unsigned integer : positive whole number or 0
            uint naturalNumber = 23;

            //integer : negarive or positive whole number or 0
            int integerNumber = -23;

            //float means single precision floating point
            float realNumber = 2.3F;

            //double : double precision floating point
            double doubleNumber = 2.3; //double literal
        }
        //gunakan double or float for real numbers that will not be compare
        public static void ShowDouble()
        {
            Console.WriteLine("Using double ;");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + b equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3}");
            }
        }
        public static void ShowDecimal()
        {
            decimal a = 0.1M; //M suffix means to decimal value
            decimal b = 0.2M;
            if (a + b == 0.3M)
            {
                Console.WriteLine($"{a} + b equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3}");
            }
        }
        public static void StoreBoolean()
        {
            bool isStatus = true;
            bool isMarried = false;
        }

        public static void StoreObject()
        {
            object obj = null;
            object firstName = "CodeId";
            object height = 1.65;

            //untuk mengetahui panjang "CodeId"
            int lengtName = ((string)firstName).Length;

            Console.WriteLine($"{firstName} is {height} metress tall, lengthFirstName :{lengtName}");
        }

        //..obj hanya disimpan di heap memory
        //boxing unboxing, stack vs heap memory
        public static void BoxingUnboxing()
        {
            int a = 42;
            object obj = a;

            obj = 45;
            int b = (int)obj;
        }

        public static void ShowDataTypeRange()
        {
            Console.WriteLine($"sbyte {sbyte.MinValue} {sbyte.MaxValue}");
            Console.WriteLine($"int {int.MinValue} {int.MaxValue}");
            Console.WriteLine($"double {double.MinValue} {double.MaxValue}");
            Console.WriteLine($"decimal {decimal.MinValue} {decimal.MaxValue}");
        }

        public static void ShowCasting()
        {
            //cast int to double
            int a = 10;
            double d = a;
            Console.WriteLine($" {d}");

            //cast double to int
            double c = 9.8;
            int b = (int)c;
        }

        public static void StoreDynamic()
        {
            //dynamic has no method or attribute (sifatnya menyimpan sementara)
            dynamic myName = "Rinima";
            Console.WriteLine($"{myName}");
        }

        public static void StoreLocal()
        {
            int salary = 10_000_000;
            double weight = 5.55; //in kg
            decimal price = 15.508M; //in IDR
            string myName = "code id";
            char letter = 'Z';
            bool married = false;
        }

        public static void StoreVar()
        {
            //ketika menggunakan var harus ditentukan valuenya.
            var salary = 10_000_000;
            var weight = 5.55; //in kg
            var price = 15.508M; //in IDR
            var myName = "code id";
            var letter = 'Z';
            var married = false;
        }

        public static void PassingParans(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        public static void ShowNullableType()
        {
            Nullable<int> a;
            Nullable<int> b = null;
            Nullable<int> c = 42;

            //lebih singkat
            int? d;
            int? e = null;
            int? f = 42;

            if (c.HasValue)
                Console.WriteLine(c.Value);
        }

        //date time
        public static void ShowDiffDate()
        {
            DateTime startdate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(10);
            DateTime.Compare(startdate, endDate);
        }

        public static void ShowArray()
        {
            int[] arr = new int[] { 1, 2, 3 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowConsole()
        {
            int numberofIphone = 12;
            decimal pricePerIphone = 1.35M;

            Console.WriteLine(
                format: "{0} iphone cost{1:C}",
                arg0: numberofIphone,
                arg1: pricePerIphone + numberofIphone);

            //interpolate string
            Console.WriteLine($"{numberofIphone} iphone cost {pricePerIphone * numberofIphone}");
        }

        public static void ReadConsole()
        {
            Console.WriteLine("FirstName:");
            string? firstName = Console.ReadLine();

            Console.WriteLine("age: ");
            string? age = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}, yo look for age {age}");
        }

        public static void ReadConsoleKey()
        {
            Console.WriteLine("Press C for continue or Escp for cancel:");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.C)
            {
                Console.WriteLine("Continue process");
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("quit process");
            }

        }
    }
}
