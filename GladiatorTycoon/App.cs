using DataContext;
using Forms;
using Repositories.Interfaces;
using Repositories.Repositories;
using System.Windows.Forms;

namespace DatabaseEditor
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
