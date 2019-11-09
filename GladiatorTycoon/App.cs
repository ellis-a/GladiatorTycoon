using GladiatorTycoon.DataContext;
using GladiatorTycoon.Forms;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Repositories.Repositories;
using System.Windows.Forms;

namespace GladiatorTycoon
{
    public class App : IApp
    {
        IPersonRepository _personRepo;
        public App(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new GladiatorTycoonDataContext();
            var personRepo = new PersonRepository(context);
            var raceRepo = new RaceRepository(context);
            var cityRepo = new CityRepository(context);
            var personNameRepo = new PersonNameRepository(context);
            Application.Run(new PersonForm(context, personRepo, raceRepo, cityRepo, personNameRepo));
        }
    }
}
