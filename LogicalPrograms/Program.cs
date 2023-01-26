namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Logical Programs");
            Console.WriteLine("\nlist of programs");
            Console.WriteLine(" 1. Fibonacci Series\n" +" 2. Perfect Number\n" +" 3. Prime Number\n" +
                " 4. Reverse a number\n" + " 5. Coupon Numbers\n" +" 6. Simulate Stopwatch Program \n");

            Console.Write(" Select an option number to run program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.TakeInput();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.TakeInput();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.TakeInput();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.TakeInput();
                    break;
                case 5:
                    CouponNumbers coupon = new CouponNumbers();
                    coupon.TakeInput();
                    break;
                case 6:
                    StopwatchSimulation stopwatch = new StopwatchSimulation();
                    stopwatch.ShowTime();
                    break;
                default:
                    Console.WriteLine(" Invalid option");
                    break;
            }
        }
    }
}