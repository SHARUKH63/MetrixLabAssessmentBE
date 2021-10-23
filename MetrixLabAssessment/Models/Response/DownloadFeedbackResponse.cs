using MetrixLabAssessment.Models.Document;
using System.Collections.Generic;

namespace MetrixLabAssessment.Models.Response
{
    /// <summary>
    /// Response class for download feedback.
    /// </summary>
    public class DownloadFeedbackResponse : FeedbackResponse
    {
        /// <summary>
        /// Gets or sets downloaded feedbacks
        /// </summary>
        public List<Feedback> Feedbacks { get; set; }

        /// <summary>
        /// Gets or sets number of feedback downloaded.
        /// </summary>
        public int FeedbackCount { get; set; }
    }
}