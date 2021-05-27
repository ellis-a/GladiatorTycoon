using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Enums;
using System.Linq;
using Services.Models;
using Repositories.Repositories;
using DataContext;
using Services.Services;
using Repositories.Interfaces;
using BattleSystem;

namespace Forms
{
    public partial class PersonForm : Form
    {
        GladiatorTycoonDataContext _context;
        private PersonService _personService;
        private PersonNameService _personNameService;
        private RaceService _raceService;
        private CityService _cityService;
        private List<Person> _persons;
        private List<Race> _races;
        private List<City> _cities;
        IPersonNameRepository _personNameRepo;

        public PersonForm(GladiatorTycoonDataContext context, IPersonRepository personRepo, IRaceRepository raceRepo, ICityRepository cityRepo, IPersonNameRepository personNameRepo)
        {
            _personNameRepo = personNameRepo;
            _context = context;
            _personNameService = new PersonNameService(personNameRepo);
            _personService = new PersonService(personRepo, raceRepo, cityRepo, personNameRepo);
            _raceService = new RaceService(raceRepo, personNameRepo);
            _cityService = new CityService(cityRepo);
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();

            ReloadUiData();
        }

        private void ReloadUiData()
        {
            ResetRaces();
            ResetStatus();
            ResetPeople();
            ResetCities();
            //listBoxOwners.Items.Clear();
            //foreach (var owner in _persons.Where(p => p.SocialStatus != SocialStatus.Slave))
            //{
            //    listBoxOwners.Items.Add(owner.FullName());
            //}
        }

        private void ResetStatus()
        {
            comboStatus.Items.Clear();
            foreach (var status in (SocialStatus[])Enum.GetValues(typeof(SocialStatus)))
            {
                comboStatus.Items.Add(status);
            }
        }

        private void ResetCities()
        {
            comboCities.Items.Clear();
            foreach (var city in _cities)
            {
                comboCities.Items.Add($"{city.Name} ({city.Habitat})");
            }
        }

        private void ResetPeople()
        {
            listPeople.Items.Clear();
            foreach (var person in _persons)
            {
                listPeople.Items.Add(person.FullName());
            }
        }

        private void ResetRaces()
        {
            comboRace.Items.Clear();
            foreach (var race in _races)
            {
                comboRace.Items.Add(race.Name);
            }
        }

        private void LoadFromDatabase()
        {
            _persons = _personService.GetAll();
            _races = _raceService.GetAll();
            _cities = _cityService.GetAll();
        }

        private void listPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPersonData();
        }

        private void btnSavePeople_Click(object sender, EventArgs e)
        {
            SavePersonData();
            LoadFromDatabase();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            var newPerson = new Person("New", "Person", SocialStatus.Lowborn, null, Gender.Male);
            _personService.Create(newPerson);
            ReloadUiData();
        }

        private void ShowPersonData()
        {
            if (listPeople.SelectedIndex == -1) { return; }

            var person = _persons[listPeople.SelectedIndex];

            textFirstName.Text = person.FirstName;
            textLastName.Text = person.LastName;
            comboRace.SelectedIndex = person.Race?.Id != null ? person.Race.Id - 1 : 0;
            comboStatus.SelectedIndex = (int)person.SocialStatus;
            comboCities.SelectedIndex = person.HomeCity?.Id != null ? person.HomeCity.Id - 1 : 0;

            if (person.Gender == Gender.Male) { radioButtonMale.Checked = true; }
            else { radioButtonFemale.Checked = true; }

            numPower.Value = person.BasePower;
            numWit.Value = person.BaseWits;
            numSkill.Value = person.BaseSkill;
            numCharisma.Value = person.BaseCharisma;
            numBravery.Value = person.BaseBravery;
            numSpeed.Value = person.Speed;
        }

        private void SavePersonData()
        {
            var person = _persons[listPeople.SelectedIndex];

            person.FirstName = textFirstName.Text;
            person.LastName = textLastName.Text;
            person.Race = _races[comboRace.SelectedIndex];
            person.Gender = radioButtonMale.Checked ? Gender.Male : Gender.Female;
            person.BasePower = (int)numPower.Value;
            person.BaseWits = (int)numWit.Value;
            person.BaseSkill = (int)numSkill.Value;
            person.BaseCharisma = (int)numCharisma.Value;
            person.SocialStatus = (SocialStatus)comboStatus.SelectedIndex;
            person.HomeCity = _cities[comboCities.SelectedIndex];

            ReloadUiData();

            _personService.Update(person);
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboStatus.SelectedIndex == 0)
            //{
            //    groupBoxSlaves.Enabled = true;
            //}
            //else
            //{
            //    groupBoxSlaves.Enabled = false;
            //}
        }

        private void btnEditRaces_Click(object sender, EventArgs e)
        {
            var raceForm = new RaceForm(new RaceRepository(_context), _personNameRepo);
            raceForm.Show();
            ResetRaces();
        }

        private void btnEditCities_Click(object sender, EventArgs e)
        {
            var cityForm = new CityForm(new CityRepository(_context));
            cityForm.Show();
            ResetCities();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var newPerson = _personService.GenerateRandomGladiator();
            _personService.Create(newPerson);
            ReloadUiData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gladiators = _personService.GetAll().Where(p => p.IsAlive).ToArray();

            var battle = new Battle(gladiators[0], gladiators[1]);
            battle.ExecuteBattle();

            _personService.Update(battle.Winner);
            _personService.Update(battle.Loser);
        }
    }
}
