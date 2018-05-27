using Autofac;
using BW.Infrastructure;

namespace BW.Core.Injection
{
    public class AutofacConfig
    {
        public static void Configure(IContainer container, string assemblyPrefix = "BW")
        {
            var builder = new ContainerBuilder();
            var assemblies = AssemblyLoad.GetAllProjectAssemblies(assemblyPrefix);
            builder.RegisterAssemblyModules(assemblies);
            builder.Update(container);
        }
    }
}
