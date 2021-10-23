using MetrixLabAssessment.Interfaces;
using System.Web.Http;

namespace MetrixLabAssessment.Controllers
{
    /// <summary>
    /// Controller to expose feedback related endpoints.
    /// </summary>
    [RoutePrefix("Feedback")]
    public class FeedbackController : ApiController
    {
        private readonly IFeedbackService _feedbackService;

        /// <summary>
        /// Initializes instance of <see cref="FeedbackController"/>.
        /// </summary>
        /// <param name="feedbackService">Instance of type <see cref="IFeedbackService"/>.</param>
        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }
    }
}
