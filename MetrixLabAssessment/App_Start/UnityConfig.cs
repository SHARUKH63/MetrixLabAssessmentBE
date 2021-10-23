using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace MetrixLabAssessment
{
    /// <summary>
    /// Unity config class to resolve dependencies.
    /// </summary>
    public static class UnityConfig
    {
        /// <summary>
        /// Registers the component and register type of resolves.
        /// </summary>
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IFeedbackService, FeedbackService>();
            container.Resolve<IFeedbackService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}