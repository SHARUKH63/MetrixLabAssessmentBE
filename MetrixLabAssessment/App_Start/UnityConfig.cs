using MetrixLabAssessment.Interfaces;
using MetrixLabAssessment.Services;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
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
            container.RegisterType<IFeedbackService, FeedbackService>(new ContainerControlledLifetimeManager());
            container.Resolve<IFeedbackService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}