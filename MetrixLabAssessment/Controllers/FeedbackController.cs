using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Models.Request;
using MetrixLabAssessment.Models.Response;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Web.Http;
using System.Net;
using System.Collections.Generic;
using MetrixLabAssessment.Filters;

namespace MetrixLabAssessment.Controllers
{
    /// <summary>
    /// Controller to expose feedback related endpoints.
    /// </summary>
    [RoutePrefix("feedback")]
    [CustomExceptionFilter]
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

        /// <summary>
        /// Saves the feedback given by candidate to memory.
        /// </summary>
        /// <param name="request"><see cref="FeedbackRequest"/>.</param>
        /// <returns><see cref="FeedbackResponse"/>.</returns>
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FeedbackResponse))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult SaveFeedback(FeedbackRequest request)
        {
            try
            {
                var response = _feedbackService.SaveFeedback(request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Downloads all submission.
        /// </summary>
        /// <returns><see cref="List{Feedback}"/>.</returns>
        [HttpGet]
        [Route("submissiondownload")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(DownloadFeedbackResponse))]
        public IHttpActionResult DownloadFeedbacks()
        {
            return Ok(_feedbackService.DownloadFeedbacks());
        }

        /// <summary>
        /// Gets count of pending downloads.
        /// </summary>
        /// <returns>Undownloaded feedback count.</returns>
        [HttpGet]
        [Route("submissioncount")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(int))]
        public IHttpActionResult PendingFeedbackDownloads()
        {
            return Ok(_feedbackService.PendingFeedbackDownloads());
        }
    }
}
