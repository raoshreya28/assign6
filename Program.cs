using System;
namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int original = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit*digit*digit;
                num /= 10;
            }
            if (sum == original)
            {
                Console.WriteLine("It is an Armstrong Number ");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong Number ");
            }
        }
    }
}
