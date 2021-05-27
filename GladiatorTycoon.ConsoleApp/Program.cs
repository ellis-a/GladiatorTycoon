using BattleSystem;
using DataContext;
using Repositories.Repositories;
using Services.Models;
using Services.Services;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var context = new GladiatorTycoonDataContext();

            var context = new GladiatorTycoonDataContext();
            var personRepo = new PersonRepository(context);
            var raceRepo = new RaceRepository(context);
            var cityRepo = new CityRepository(context);
            var personNameRepo = new PersonNameRepository(context);

            var personService = new PersonService(personRepo, raceRepo, cityRepo, personNameRepo);

            var gladiators = personService.GetAll();

            var battle = new Battle(gladiators[0] as Gladiator, gladiators[1] as Gladiator);
            battle.ExecuteBattle();
        }
    }
}
