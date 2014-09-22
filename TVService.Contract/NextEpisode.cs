using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TVService.Contract
{
    [DataContract]
    public class NextEpisode
    {
        [DataMember]
        public object channel { get; set; }
        [DataMember]
        public string channelLogo { get; set; }
        [DataMember]
        public object date { get; set; }
        [DataMember]
        public string html { get; set; }
        [DataMember]
        public string url { get; set; }
    }
}
