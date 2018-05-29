using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BasicWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Calculate(int selection, int a, int b);

        int Add(int a, int b);

        int Subtract(int a, int b);

        int Multiply(int a, int b);

        int Division(int a, int b);

    }
}
