using BasicWCFService;
using SharedClass;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace BasicWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        ResultAcknowledgement acknowledge = new ResultAcknowledgement();
        public ResultAcknowledgement Add(CalculatorInputs numbers)
        {
            try
            {
                int a = Convert.ToInt32(numbers.a);
                int b = Convert.ToInt32(numbers.b);
                acknowledge.Result = true;
                acknowledge.ResultValue = a + b;

                return acknowledge;  
            }
            catch(Exception ex)
            {
                acknowledge.message = ex.Message;
                acknowledge.Result = false;
                return acknowledge;
            }

        }

        public ResultAcknowledgement Division(CalculatorInputs numbers)
        {
            try
            {
                int a = Convert.ToInt32(numbers.a);
                int b = Convert.ToInt32(numbers.b);
                acknowledge.Result = true;
                acknowledge.ResultValue = a / b;

                return acknowledge;
            }
            catch (Exception ex)
            {
                acknowledge.message = ex.Message;
                acknowledge.Result = false;
                return acknowledge;
            }
        }

        public ResultAcknowledgement Multiply(CalculatorInputs numbers)
        {
            try
            {
                int a = Convert.ToInt32(numbers.a);
                int b = Convert.ToInt32(numbers.b);
                acknowledge.Result = true;
                acknowledge.ResultValue = a * b;

                return acknowledge;
            }
            catch (Exception ex)
            {
                acknowledge.message = ex.Message;
                acknowledge.Result = false;
                return acknowledge;
            }
        }

        public ResultAcknowledgement Subtract(CalculatorInputs numbers)
        {
            try
            {
                int a = Convert.ToInt32(numbers.a);
                int b = Convert.ToInt32(numbers.b);
                acknowledge.Result = true;
                acknowledge.ResultValue = a - b;

                return acknowledge;
            }
            catch (Exception ex)
            {
                acknowledge.message = ex.Message;
                acknowledge.Result = false;
                return acknowledge;
            }
        }
    }
}
