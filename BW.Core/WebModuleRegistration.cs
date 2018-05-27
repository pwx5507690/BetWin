using Autofac;
using Autofac.Integration.Mvc;
using BW.Infrastructure;

namespace BW.Core.Injection
{
    public class WebModuleRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            if (Config.IocAssembly.IsNotNullOrEmpty())
                Config.IocAssembly.Split(',').Each(t => builder
                .RegisterAssemblyTypes(AssemblyLoad.GetAllProjectAssemblies(t.ToString().Trim()))
                .PropertiesAutowired());

            if (Config.Controllers.IsNotNullOrEmpty())
            {
                var mvc = AssemblyLoad.GetAllProjectAssemblies(Config.Controllers);
                if (mvc != null)
                    builder.RegisterControllers(mvc);
            }
            builder.RegisterFilterProvider();
        }
    }
}
