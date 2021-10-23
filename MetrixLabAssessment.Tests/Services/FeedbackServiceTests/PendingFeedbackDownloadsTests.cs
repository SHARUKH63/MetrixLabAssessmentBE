using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixLabAssessment.Tests.Services.FeedbackServiceTests
{
    [TestClass]
    public class PendingFeedbackDownloadsTests : FeedServiceTestBase
    {
        [TestMethod]
        public void ExpectValidResponseWhenPendingDownloadCountIsRetrieved()
        {
            var response = feedbackService.PendingFeedbackDownloads();
            Assert.IsNotNull(response, "Expect response to be not null when pending feedback download count is retrieved.");
        }
    }
}
