namespace Day6LogicalPrograms
{
    public class Program
    {
        public static void Main(string[]args)
        {
            //Console.WriteLine("Welcome To Day 6 Logical Programs");
            //Fibonacci.PrintingFibonacci();
            //PerfectNumber.ThePerfectNumber();
            //PrimeNumber.FindThePrimeNumber();
            //ReverseNumber.ReverseTheNumber();
            Console.WriteLine("Enter N Value");
            CouponNumber c = new CouponNumber();
            int N = Convert.ToInt32(Console.ReadLine());
            CouponNumber.Coupon(N);
        }
    }
}