using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TVService.Contract
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string slug { get; set; }
        [DataMember]
        public string title { get; set; }
    }
}
