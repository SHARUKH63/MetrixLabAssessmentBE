using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetrixLabAssessment.Tests.Controllers.FeedbackControllerTests
{
    [TestClass]
    public class PendingFeedbackDownloadsTests : FeedbackControllerTestBase
    {
        [TestMethod]
        public void ExpectValidResponseWhenRetrievePendingFeedbackDownload()
        {
            var response = Controller.DownloadFeedbacks();
            Assert.IsNotNull(response, "Expect not null response when feedback is downloaded successfully.");
        }
    }
}
