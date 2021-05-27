using Autofac;
using DataContext;
using System.Linq;
using System.Reflection;

namespace DatabaseEditor
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<GladiatorTycoonDataContext>().AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load("Repositories"))
                .Where(t => t.Namespace.Contains("Repositories"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            return builder.Build();
        }
    }
}
