namespace BasicWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }

        public int Calculate(int selection,int a, int b)
        {
            int value = 0;
            switch (selection)
            {
                case 1:
                    value = Add(a, b);
                    return value;
                case 2:
                    value= Subtract(a,b);
                    return value;
                case 3:
                    value = Multiply(a,b);
                    return value;
                case 4:
                    value = Division(a, b);
                    return value;
            }
            return value;
        }

        public int Division(int a ,int b)
        {
            if(a >=b && b!=0)
            return a / b;
            return 0;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
