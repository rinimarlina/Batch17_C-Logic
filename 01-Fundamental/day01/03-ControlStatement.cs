namespace day01
{
    class ControlStatement
    {
        public static void ValidatePassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password required");
            }
            else if (password.Length < 8)
            {
                Console.WriteLine("Your password is to short, at least 8 character");
            }
            else
            {
                Console.WriteLine("Your password is strong");
            }
        }

        public static void EventOddNumber()
        {
            Console.WriteLine("Enter a number :");
            var inout = Console.ReadLine();
            //int number = Convert.ToInt32(inout); //code punya pak dian (input)
            int.TryParse(inout, out int number); //cara ke 2   

            if (number % 2 == 0)
            {
                Console.WriteLine("Event number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Enter a number 1-10 :");
            var input = Console.ReadLine();

            int.TryParse(input, out int number);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Smallest Number");
                    break;//break : agar keluar dari kondisi looping
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime Number");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even Number");
                    break;
                case 9:
                    Console.WriteLine("Odd Number");
                    break;
                case 10:
                    Console.WriteLine("Highest Number");
                    break;
                default:
                    Console.WriteLine("Not in the range");
                    break;
            }
        }
    }
}