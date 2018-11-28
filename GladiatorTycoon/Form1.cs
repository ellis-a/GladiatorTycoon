using System;
using System.Windows.Forms;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using GladiatorTycoon.Repository;
using GladiatorTycoon.Enums;

namespace GladiatorTycoon
{
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private List<Race> races;
        private List<City> cities;

        public Form1()
        {
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
            RacesGroupBox();
        }

        private void RacesGroupBox()
        {
            listRaces.Items.Clear();
            foreach (var race in races)
            {
                listRaces.Items.Add(race.Name);
            }
        }

        private void PeopleGroupBox()
        {
            comboRace.Items.Clear();
            listPeople.Items.Clear();
            comboStatus.Items.Clear();
            comboCities.Items.Clear();
            foreach (var race in races)
            {
                comboRace.Items.Add(race.Name);
            }
            foreach (var status in (SocialStatus[])Enum.GetValues(typeof(SocialStatus)))
            {
                comboStatus.Items.Add(status);
            }
            foreach (var person in persons)
            {
                listPeople.Items.Add(person.FullName());
            }
            foreach (var city in cities)
            {
                comboCities.Items.Add($"{city.Name} ({city.Habitat})");
            }
        }

        private void LoadFromDatabase()
        {
            persons = new List<Person>();
            races = new List<Race>();
            cities = new List<City>();
            var personRepo = new PersonRepository();
            var racesRepo = new RaceRepository();
            var citiesRepo = new CityRepository();
            persons.AddRange(personRepo.GetAllPersons());
            races.AddRange(racesRepo.GetAllRaces());
            cities.AddRange(citiesRepo.GetAllCities());
        }

        private void listPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePersonData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            persons.Add(new Person("New", "Person", SocialStatus.Lowborn, null, true));
            ReloadUiData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            if (listPeople.SelectedIndex == -1) { return; }

            var person = persons[listPeople.SelectedIndex];

            textFirstName.Text = person.FirstName;
            textLastName.Text = person.LastName;
            comboRace.SelectedIndex = person.Race?.Id == null ? person.Race.Id - 1 : 0;
            comboStatus.SelectedIndex = (int)person.SocialStatus;
            comboCities.SelectedIndex = person.HomeCity?.Id != null ? person.HomeCity.Id - 1 : 0;

            if (person.IsMale) { radioButtonMale.Checked = true; }
            else { radioButtonFemale.Checked = true; }

            numStrength.Value = person.Strength;
            numIntelligence.Value = person.Intelligence;
            numAgility.Value = person.Agility;
            numCharisma.Value = person.Charisma;
        }

        private void SavePersonData()
        {
            var person = persons[listPeople.SelectedIndex];

            person.FirstName = textFirstName.Text;
            person.LastName = textLastName.Text;
            person.Race = races[comboRace.SelectedIndex];

            person.IsMale = radioButtonMale.Checked;

            person.Strength = (int)numStrength.Value;
            person.Intelligence = (int)numIntelligence.Value;
            person.Agility = (int)numAgility.Value;
            person.Charisma = (int)numCharisma.Value;

            person.SocialStatus = (SocialStatus) comboStatus.SelectedIndex;
            person.HomeCity = cities[comboCities.SelectedIndex];

            ReloadUiData();

            var personRepo = new PersonRepository();
            personRepo.SavePersons(persons);
        }
    }
}
