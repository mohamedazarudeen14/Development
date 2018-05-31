using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BasicWCFService
{
    [DataContract]
    public class CalculatorInputs
    {
        [DataMember]
        public string a { get; set; }
        [DataMember]
        public string b { get; set; }
    }
}