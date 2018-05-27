using Autofac;
using Autofac.Integration.Mvc;
using BW.Infrastructure;
using System.Web.Mvc;

namespace BW.Core.Injection
{
    public static class Bootstrap
    {
        public static void ConfigureMvc(IContainer container)
        {
            if (Config.Controllers.IsNotNullOrEmpty())
                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        public static void ConfigureApplication(IContainer container)
        {
            AssemblyLoad.ForceLoadAllReferencedAssemblies();
            AutofacConfig.Configure(container);
        }
    }
}
