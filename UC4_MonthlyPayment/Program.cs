using System;
using System.Runtime.CompilerServices;

namespace UC4_MonthlyPayment
{
    public class MonthlyPayment
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter Principal Amount : ");
            int P = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Rate of Interest : ");
            int R = int.Parse(Console.ReadLine());
           
            Console.Write("Enter Time period in years : ");
            int Y = int.Parse(Console.ReadLine());

            int n = 12 * Y;
            int r = R / (12 * 100);
            int p= (P*r)/1-(1+r)^(-n);
            
           
            Console.WriteLine("Payment: " , p);
        }
    }
}
