using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithService
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalCalculator digitalCalculator = new DigitalCalculator();
            digitalCalculator.Calculation();
            Console.Read();
        }
    }
}
