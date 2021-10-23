using MetrixLabAssessment.Models.Document;
using MetrixLabAssessment.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MetrixLabAssessment.Tests.Services.FeedbackServiceTests
{
    [TestClass]
    public class DownloadFeedbacksTests : FeedServiceTestBase
    {
        [TestMethod]
        public void ExpectValidResponseWhenFeedbackDownloaded()
        {
            var response = feedbackService.DownloadFeedbacks();
            Assert.IsNotNull(response, "Expect response to be not null when feedback is downloaded.");
        }

        protected override void Seed()
        {
            base.Seed();
            FeedbackService.s_feedbackList = new List<Feedback>()
            {
                new Feedback()
            };
        }
    }
}
