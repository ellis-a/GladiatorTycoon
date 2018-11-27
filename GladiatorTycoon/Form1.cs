using System;
using System.Windows.Forms;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using GladiatorTycoon.Repository;

namespace GladiatorTycoon
{
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private List<Race> races;

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
            comboRace.Items.Clear();
            listPeople.Items.Clear();
            foreach (var race in races)
            {
                comboRace.Items.Add(race.Name);
            }

            foreach (var person in persons)
            {
                listPeople.Items.Add(person.FullName());
            }
        }

        private void LoadFromDatabase()
        {
            persons = new List<Person>();
            races = new List<Race>();
            var personRepo = new PersonRepository();
            var racesRepo = new RaceRepository();
            persons.AddRange(personRepo.GetAllPersons());
            races.AddRange(racesRepo.GetAllRaces());
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
            persons.Add(new Person("New", "Person", 0, null, true));
            ReloadUiData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            var person = persons[listPeople.SelectedIndex];

            textFirstName.Text = person.FirstName;
            textLastName.Text = person.LastName;
            if (person.Race != null)
            {
                comboRace.SelectedIndex = person.Race.Id - 1;
            }
            else
            {
                comboRace.SelectedIndex = 0;
            }

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

            ReloadUiData();
        }
    }
}
