using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;

namespace MetrixLabAssessment.Tests
{
    [TestClass]
    public abstract class ControllerUnitTestBase<T> : UnitTestBase
        where T: ApiController
    {
        public T Controller { get; set; }

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            Controller = CreateController();
        }

        protected abstract T CreateController();
    }
}
