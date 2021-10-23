using MetrixLabAssessment.Controllers;
using MetrixLabAssessment.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace MetrixLabAssessment.Tests.Controllers.FeedbackControllerTests
{
    [TestClass]
    public class FeedbackControllerTestBase : ControllerUnitTestBase<FeedbackController>
    {
        protected override FeedbackController CreateController()
        {         
            return new FeedbackController(container.Resolve<IFeedbackService>());
        }
    }
}
