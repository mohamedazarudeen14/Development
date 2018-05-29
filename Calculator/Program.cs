using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Selection");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Division");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the A and B values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            CalculatorService.CalculatorClient digitalCal = new CalculatorService.CalculatorClient();
            Console.WriteLine("The Answer is {0}",digitalCal.Calculate(selection, a, b));
            Main(args);
            Console.Read();
        }
    }
}
