using NLog;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace MetrixLabAssessment.Filters
{
    /// <summary>
    /// Custom exception filter class.
    /// </summary>
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        private static readonly ILogger s_logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// On exception method.
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            s_logger.Error(actionExecutedContext.Exception.Message);
            actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("Unexpected exception occured.")
            };
        }
    }
}