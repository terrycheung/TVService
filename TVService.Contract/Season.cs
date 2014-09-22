using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TVService.Contract
{
    [DataContract]
    public class Season
    {
        [DataMember]
        public string slug { get; set; }
    }
}
