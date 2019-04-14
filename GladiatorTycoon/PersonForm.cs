using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GladiatorTycoon.Enums;
using System.Linq;
using GladiatorTycoon.Services.Models;
using GladiatorTycoon.Repositories.Repositories;
using GladiatorTycoon.DataContext;
using GladiatorTycoon.Services.Services;
using GladiatorTycoon.Repositories.Interfaces;

namespace GladiatorTycoon
{
    public partial class PersonForm : Form
    {
        private PersonService _personService;
        private RaceService _raceService;
        private CityService _cityService;
        private List<Person> _persons;
        private List<Race> _races;
        private List<City> _cities;

        public PersonForm(IPersonRepository personRepo, IRaceRepository raceRepo, ICityRepository cityRepo)
        {
            _personService = new PersonService(personRepo);
            _raceService = new RaceService(raceRepo);
            _cityService = new CityService(cityRepo);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();

            ReloadUiData();
        }

        private void ReloadUiData()
        {
            PeopleGroupBox();
        }

        private void PeopleGroupBox()
        {
            comboRace.Items.Clear();
            listPeople.Items.Clear();
            comboStatus.Items.Clear();
            comboCities.Items.Clear();
            listBoxOwners.Items.Clear();
            foreach (var race in _races)
            {
                comboRace.Items.Add(race.Name);
            }
            foreach (var status in (SocialStatus[])Enum.GetValues(typeof(SocialStatus)))
            {
                comboStatus.Items.Add(status);
            }
            foreach (var person in _persons)
            {
                listPeople.Items.Add(person.FullName());
            }
            foreach (var city in _cities)
            {
                comboCities.Items.Add($"{city.Name} ({city.Habitat})");
            }
            foreach (var owner in _persons.Where(p => p.SocialStatus != SocialStatus.Slave))
            {
                listBoxOwners.Items.Add(owner.FullName());
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
            _persons.Add(new Person("New", "Person", SocialStatus.Lowborn, null, true));
            ReloadUiData();
        }

        private void btnCancelPerson_Click(object sender, EventArgs e)
        {
            ShowPersonData();
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

            if (person.IsMale) { radioButtonMale.Checked = true; }
            else { radioButtonFemale.Checked = true; }

            numPower.Value = person.Power;
            numWits.Value = person.Wits;
            numSpeed.Value = person.Speed;
            numCharisma.Value = person.Charisma;
        }



        private void SavePersonData()
        {
            var person = _persons[listPeople.SelectedIndex];

            person.FirstName = textFirstName.Text;
            person.LastName = textLastName.Text;
            person.Race = _races[comboRace.SelectedIndex];
            person.IsMale = radioButtonMale.Checked;
            person.Power = (int)numPower.Value;
            person.Wits = (int)numWits.Value;
            person.Speed = (int)numSpeed.Value;
            person.Charisma = (int)numCharisma.Value;
            person.SocialStatus = (SocialStatus)comboStatus.SelectedIndex;
            person.HomeCity = _cities[comboCities.SelectedIndex];

            ReloadUiData();

            //TODO: save here
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            _races.Add(new Race(){ Name = "NewRace" });
            ReloadUiData();
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStatus.SelectedIndex == 0)
            {
                groupBoxSlaves.Enabled = true;
            }
            else
            {
                groupBoxSlaves.Enabled = false;
            }
        }

        private void btnSlaveSave_Click(object sender, EventArgs e)
        {

        }
    }
}
