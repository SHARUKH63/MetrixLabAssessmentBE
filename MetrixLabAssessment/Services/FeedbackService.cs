using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Models.Document;
using MetrixLabAssessment.Models.Request;
using MetrixLabAssessment.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MetrixLabAssessment.Services
{
    /// <summary>
    /// Service class which handles feedback operations.
    /// </summary>
    public class FeedbackService : IFeedbackService
    {
        /// <summary>
        /// Acts as inmemory, where all feedbacks is being saved.
        /// </summary>
        public static List<Feedback> s_feedbackList;

        /// <summary>
        /// Saves the feedback given by candidate to memory.
        /// </summary>
        /// <param name="request"><see cref="FeedbackRequest"/>.</param>
        /// <returns><see cref="FeedbackResponse"/>.</returns>
        public FeedbackResponse SaveFeedback(FeedbackRequest request)
        {
            if (request == null)
            {
                throw new ArgumentException("Request cannot be null.");
            }

            if (s_feedbackList == null)
            {
                s_feedbackList = new List<Feedback>();
            }

            s_feedbackList.Add(new Feedback
            {
                IsInterviewTimeAndMannerClear = request.IsInterviewTimeAndMannerClear,
                IsInterviewOnTime = request.IsInterviewOnTime,
                FeedbackText = request.FeedbackText,
                PositionType = request.PositionType.ToString(),
                Topics = request.Topics
            });

            return new FeedbackResponse { IsSuccessful = true, Message = "Thanks for submitting feedback." };
        }

        /// <summary>
        /// Downloads all undownloaded feedbacks.
        /// </summary>
        /// <returns><see cref="List{Feedback}"/>.</returns>
        public DownloadFeedbackResponse DownloadFeedbacks()
        {
            var feedbacks = new List<Feedback>();

            s_feedbackList?.ForEach(feedback =>
            {
                if (!feedback.IsDownloaded)
                {
                    feedback.IsDownloaded = true;
                    feedbacks.Add(feedback);
                }
            });

            return new DownloadFeedbackResponse
            {
                Feedbacks = feedbacks,
                FeedbackCount = feedbacks?.Count() ?? 0,
                IsSuccessful = true,
                Message = "Feedbacks downloaded successfully"
            };
        }

        /// <summary>
        /// Returns number of pending feedbacks to be downloaded.
        /// </summary>
        /// <returns>Number indicating undownloaded feedbacks.</returns>
        public int PendingFeedbackDownloads()
        {
            return s_feedbackList?.Where(feedback => !feedback.IsDownloaded).Count() ?? 0;
        }
    }
}