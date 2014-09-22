using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TVService.Contract
{
    [DataContract]
    public class ErrorResponse
    {
        public ErrorResponse(string error)
        {
            Error = error;
        }

        [DataMember]
        public string Error { get; private set; }

    }
}
