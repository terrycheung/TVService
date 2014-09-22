using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TVService.Contract;

namespace TVService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "", BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "response")]
        List<Response> Query(Request r);
    
    }



}
