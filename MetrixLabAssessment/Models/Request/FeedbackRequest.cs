using MetrixLabAssessment.Models.Enum;
using System.Collections.Generic;

namespace MetrixLabAssessment.Models.Request
{
    /// <summary>
    /// Feedback request model.
    /// </summary>
    public class FeedbackRequest
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
        /// Gets or sets position type of candidate.
        /// </summary>
        public PositionType PositionType { get; set; }

        /// <summary>
        /// Gets or sets list of topics which has been asked in interview.
        /// </summary>
        public List<string> Topics { get; set; }
    }
}