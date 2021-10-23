using System;
using System.Web.Http.Results;
using MetrixLabAssessment.Controllers;
using MetrixLabAssessment.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MetrixLabAssessment.Tests.Controllers.FeedbackControllerTests
{
    [TestClass]
    public class SaveFeedbackTests : FeedbackControllerTestBase
    {
        [TestMethod]
        public void ExpectValidResponseWhenFeedbackIsSubmittedSuccessfully()
        {
            var response = Controller.SaveFeedback(new Models.Request.FeedbackRequest());
            Assert.IsNotNull(response, "Expect not null response when feedback is saved successfully.");
        }

        [TestMethod]
        public void ExpectBadRequstExceptionWhenServiceReturnsBadRequest()
        {
            var mockService = new Mock<IFeedbackService>();
            mockService
                .Setup(x => x.SaveFeedback(It.IsAny<Models.Request.FeedbackRequest>()))
                .Throws(new ArgumentException());

            var subjectUnderTest = new FeedbackController(mockService.Object);

            var response = subjectUnderTest.SaveFeedback(new Models.Request.FeedbackRequest());
            Assert.IsTrue(response is BadRequestErrorMessageResult, "Expect a bad request when service returns bad request exception.");
        }
    }
}
