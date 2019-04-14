using GladiatorTycoon.DataContext;
using GladiatorTycoon.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladiatorTycoon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new GladiatorTycoonDataContext();
            var personRepo = new PersonRepository(context);
            var raceRepo = new RaceRepository(context);
            var cityRepo = new CityRepository(context);
            Application.Run(new PersonForm(personRepo, raceRepo, cityRepo));
        }
    }
}
