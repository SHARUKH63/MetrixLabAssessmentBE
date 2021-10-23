using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Services;

namespace MetrixLabAssessment.Tests.Services.FeedbackServiceTests
{
    public class FeedServiceTestBase : UnitTestBase
    {
        protected IFeedbackService feedbackService { get; set; }

        protected override void Seed()
        {
            feedbackService = new FeedbackService();
        }
    }
}
