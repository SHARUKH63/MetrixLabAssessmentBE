using MetrixLabAssessment.Models.Document;
using MetrixLabAssessment.Models.Request;
using MetrixLabAssessment.Models.Response;
using System.Collections.Generic;

namespace MetrixLabAssessment.Interfaces
{
    /// <summary>
    /// Interface for registering feedback service.
    /// </summary>
    public interface IFeedbackService
    {
        /// <summary>
        /// Saves the feedback given by candidate to memory.
        /// </summary>
        /// <param name="request"><see cref="FeedbackRequest"/>.</param>
        /// <returns><see cref="FeedbackResponse"/>.</returns>
        FeedbackResponse SaveFeedback(FeedbackRequest request);

        /// <summary>
        /// Downloads all undownloaded feedbacks.
        /// </summary>
        /// <returns><see cref="DownloadFeedbackResponse"/>.</returns>
        DownloadFeedbackResponse DownloadFeedbacks();

        /// <summary>
        /// Returns number of pending feedbacks to be downloaded.
        /// </summary>
        /// <returns>Number indicating undownloaded feedbacks.</returns>
        int PendingFeedbackDownloads();
    }
}
