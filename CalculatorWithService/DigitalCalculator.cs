using CalculatorWithService.CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithService
{
    public class DigitalCalculator
    {
        public void Calculation()
        {
            try
            {
                Console.WriteLine("Enter Your Selection");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Division");
                int selection = Convert.ToInt32(Console.ReadLine());
              
                CalculatorClient digitalCal = new CalculatorClient();
                ResultAcknowledgement acknowledge = null;
                CalculatorInputs values = new CalculatorInputs();

                if (selection > 0 && selection <= 4)
                {
                    Console.WriteLine("Enter the A and B values");
                    values.a = Console.ReadLine();
                    values.b = Console.ReadLine();
                    switch (selection)
                    {
                        case 1:
                            acknowledge = digitalCal.Add(values);
                            break;
                        case 2:
                            acknowledge = digitalCal.Subtract(values);
                            break;
                        case 3:
                            acknowledge = digitalCal.Multiply(values);
                            break;
                        case 4:
                            acknowledge = digitalCal.Division(values);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Give Proper Selection for what you want to do");
                    Calculation();
                }

                Console.WriteLine(acknowledge.Result ? string.Format("The Result is {0} and the Answer is {1}", acknowledge.Result, acknowledge.ResultValue)
                    : string.Format("The Result is {0} and the message is {1}", acknowledge.Result, acknowledge.message));

                Calculation();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Calculation();
            }
        }
    }
}
