using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Models.Request;
using MetrixLabAssessment.Models.Response;

namespace MetrixLabAssessment.Tests.TestServices
{
    public class TestFeedbackService : IFeedbackService
    {
        public DownloadFeedbackResponse DownloadFeedbacks()
        {
            return new DownloadFeedbackResponse();
        }

        public int PendingFeedbackDownloads()
        {
            return 0;
        }

        public FeedbackResponse SaveFeedback(FeedbackRequest request)
        {
            return new FeedbackResponse();
        }
    }
}
