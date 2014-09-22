using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TVService.Contract
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public string showImage { get; set; }
    }
}
