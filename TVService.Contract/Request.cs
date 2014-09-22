using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace TVService.Contract
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public List<Payload> payload { get; set; }

        [DataMember]
        public int skip { get; set; }

        [DataMember]
        public int take { get; set; }

        [DataMember]
        public int totalRecords { get; set; }
    }
}
