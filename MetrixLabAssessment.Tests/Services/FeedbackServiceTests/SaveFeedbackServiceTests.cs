using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MetrixLabAssessment.Tests.Services.FeedbackServiceTests
{
    [TestClass]
    public class SaveFeedbackServiceTests : FeedServiceTestBase
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Request cannot be null.")]
        public void ExpectArgumentExceptionWhenRequestIsNull()
        {
            feedbackService.SaveFeedback(null);
        }

        [TestMethod]
        public void ExpectValidResponseWhenFeedbackSavedSuccessfully()
        {
            var response = feedbackService.SaveFeedback(new Models.Request.FeedbackRequest());
            Assert.IsNotNull(response, "Expect response to be not null when success.");
        }
    }
}
