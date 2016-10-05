using System;
using System.Linq;

namespace _01_Calculator
{
    public class Calculator
    {
        public static double Add(double a, double b){ return a + b;}
        public static double Subtract(double a, double b){ return a - b;}
        public static double Sum(int[] numbers){ return numbers.Sum();}
        public static double Sum(double[] numbers){ return numbers.Sum();}
        public static double Multiply(double a, double b){ return a * b;}
        public static double Multiply(int[] numbers)
        {
            double total = 1;

            foreach(double number in numbers)
            {
                total *= number;
            }

            return total;
        }
        public static double Power(double a, double b){ return Math.Pow(a,b);}

        public static int Factorial(int a)
        {
            int total = a;

            if(a == 0 || a == 1)
                return 1;

            for(int i = --a; i > 0; i--)
            {
                total *= i;
            }

            return total;
        }


        



    }
}