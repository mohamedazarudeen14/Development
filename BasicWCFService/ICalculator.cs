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
        ResultAcknowledgement Add(CalculatorInputs numbers);

        [OperationContract]
        ResultAcknowledgement Subtract(CalculatorInputs numbers);

        [OperationContract]
        ResultAcknowledgement Multiply(CalculatorInputs numbers);

        [OperationContract]
        ResultAcknowledgement Division(CalculatorInputs numbers);
    }
}
