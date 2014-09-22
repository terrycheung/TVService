using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using TVService.BusinessLogic;
using TVService.Contract;
using TVService.Util;

namespace TVService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceErrorBehaviour(typeof(ErrorHandler))]
    public class Service : IService
    {

        Television television; 

        public Service()
        {
            television = new Television();
        }


        public List<Response> Query(Request r)
        {
            try
            {
                return (television.GetDRMEnabledAndHasEpisodes(r.payload));
            }
            catch (Exception ex)
            {
                ErrorResponse errorData = new ErrorResponse(ex.Message);
                throw new WebFaultException<ErrorResponse>(errorData, HttpStatusCode.BadRequest); 
            }
        }
    }
}
