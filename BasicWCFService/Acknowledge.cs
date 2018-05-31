using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BasicWCFService
{
    [DataContract]
    public class ResultAcknowledgement
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public int ResultValue { get; set; }
        [DataMember]
        public string message { get; set; }
    }
}