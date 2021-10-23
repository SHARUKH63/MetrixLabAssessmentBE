using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Tests.TestServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace MetrixLabAssessment.Tests
{
    [TestClass]
    public class UnitTestBase
    {
        protected IUnityContainer container;

        [TestInitialize]
        public virtual void Setup()
        {
            container = new UnityContainer();
            container.RegisterType<IFeedbackService, TestFeedbackService>();
            container.Resolve<IFeedbackService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
