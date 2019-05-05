using Autofac;
using GladiatorTycoon.DataContext;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Repositories.Repositories;
using System.Linq;
using System.Reflection;

namespace GladiatorTycoon
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<GladiatorTycoonDataContext>().AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load("GladiatorTycoon.Repositories"))
                .Where(t => t.Namespace.Contains("Repositories"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            return builder.Build();
        }
    }
}
