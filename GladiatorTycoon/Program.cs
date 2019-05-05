using Autofac;
using System;
using System.Windows.Forms;

namespace GladiatorTycoon.DatabaseEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApp>();
                app.Run();
            }
        }
    }
}
