using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetrixLabAssessment.Models.Document
{
    /// <summary>
    /// Feedback document model, which saves the entered feedback by candidate.
    /// </summary>
    public class Feedback
    {
        /// <summary>
        /// Gets or sets value indicating whether interview time and manner was clear to candidate.
        /// </summary>
        public bool IsInterviewTimeAndMannerClear { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether interview has happend on time.
        /// </summary>
        public bool IsInterviewOnTime { get; set; }

        /// <summary>
        /// Gets or sets feedback text from candidate.
        /// </summary>
        public string FeedbackText { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the feedback is downlaoded or not.
        /// </summary>
        public bool IsDownloaded { get; set; }

        /// <summary>
        /// Gets or sets position type of candidate.
        /// </summary>
        public string PositionType { get; set; }

        /// <summary>
        /// Gets or sets list of topics which has been asked in interview.
        /// </summary>
        public List<string> Topics { get; set; }
    }
}