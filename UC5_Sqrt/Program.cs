using System;

namespace UC5_Sqrt
{
    public class Sqrt
    {
        public static void Main(string[] args)
        {
            double epsilon = 1.0e-15;
            Console.Write("Enter the guess value : ");
            double guess = int.Parse(Console.ReadLine());
         
            double result = 0.0;

            double value = 2;

            result = ((value / guess) + guess) / 2;

            do
            {
                Console.WriteLine("Guess Value  = {0}", guess);
                Console.WriteLine("Result Value = {0}", result);
                guess = result;
                result = ((value / guess) + guess) / 2;
            } while (Math.Abs(result - guess) > epsilon);
            Console.WriteLine("The approx sqrt of {0} is {1}", value, result);
        }
    }
}
