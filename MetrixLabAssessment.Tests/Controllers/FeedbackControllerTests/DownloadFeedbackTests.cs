using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetrixLabAssessment.Tests.Controllers.FeedbackControllerTests
{
    [TestClass]
    public class DownloadFeedbackTests : FeedbackControllerTestBase
    {
        [TestMethod]
        public void ExpectValidResponseWhenFeedbackIsDownloaded()
        {
            var response = Controller.PendingFeedbackDownloads();
            Assert.IsNotNull(response, "Expect not null response when pending feedback count is retrieved.");
        }
    }
}
