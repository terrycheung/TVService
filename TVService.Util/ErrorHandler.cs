using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using TVService.Contract;

namespace TVService.Util
{
    /* Had to implement a custom error handler to handle situations where the JSON is malformed and cannot be serialized */
    public class ErrorHandler : IErrorHandler
    {

        public bool HandleError(Exception error)
        {
            try
            {
          
            }
            catch { }
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion ver, ref Message fault)
        {
            try
            {

                ErrorResponse jsonError;

                if (error is System.Runtime.Serialization.SerializationException)
                {
                    jsonError = new ErrorResponse("Could not decode request: JSON parsing failed");
                    WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.BadRequest;
                }
                else
                {
                    jsonError = new ErrorResponse(error.Message);
                    WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                }


                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json;

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ErrorResponse));
                Message msgFault = Message.CreateMessage(ver, "*", jsonError, jsonSerializer);
                msgFault.Properties.Add(WebBodyFormatMessageProperty.Name, new WebBodyFormatMessageProperty(WebContentFormat.Json));
                fault = msgFault;
            }
            catch { }
        }
    }
}
