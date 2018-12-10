using System;
using System.Windows.Forms;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using GladiatorTycoon.Repository;
using GladiatorTycoon.Enums;
using System.Linq;

namespace GladiatorTycoon
{
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private List<Gladiator> gladiatorsAndSlaves;
        private List<Race> races;
        private List<City> cities;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repo = new SlaveRepository();
            repo.GetAllSlaves();

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
            chkListPositiveHabitats.Items.Clear();
            chkListNegativeHabitats.Items.Clear();
            foreach (var race in races)
            {
                listRaces.Items.Add(race.Name);
            }
            foreach (var habitat in (Habitat[])Enum.GetValues(typeof(Habitat)))
            {
                chkListPositiveHabitats.Items.Add(habitat);
            }
            foreach (var habitat in (Habitat[])Enum.GetValues(typeof(Habitat)))
            {
                chkListNegativeHabitats.Items.Add(habitat);
            }
        }

        private void PeopleGroupBox()
        {
            comboRace.Items.Clear();
            listPeople.Items.Clear();
            comboStatus.Items.Clear();
            comboCities.Items.Clear();
            listBoxOwners.Items.Clear();
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
            foreach (var owner in persons.Where(p => p.SocialStatus != SocialStatus.Slave))
            {
                listBoxOwners.Items.Add(owner.FullName());
            }
        }

        private void LoadFromDatabase()
        {
            persons = new List<Person>();
            races = new List<Race>();
            cities = new List<City>();
            gladiatorsAndSlaves = new List<Gladiator>();
            var personRepo = new PersonRepository();
            var raceRepo = new RaceRepository();
            var cityRepo = new CityRepository();
            var gladiatorRepo = new GladiatorRepository();
            persons.AddRange(personRepo.GetAllPersons());
            races.AddRange(raceRepo.GetAllRaces());
            cities.AddRange(cityRepo.GetAllCities());
            //gladiatorsAndSlaves.AddRange(gladiatorRepo.GetAllPersons);
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
            persons.Add(new Person("New", "Person", SocialStatus.Lowborn, null, true));
            ReloadUiData();
        }

        private void btnCancelPerson_Click(object sender, EventArgs e)
        {
            ShowPersonData();
        }

        private void ShowPersonData()
        {
            if (listPeople.SelectedIndex == -1) { return; }

            var person = persons[listPeople.SelectedIndex];

            textFirstName.Text = person.FirstName;
            textLastName.Text = person.LastName;
            comboRace.SelectedIndex = person.Race?.Id != null ? person.Race.Id - 1 : 0;
            comboStatus.SelectedIndex = (int)person.SocialStatus;
            comboCities.SelectedIndex = person.HomeCity?.Id != null ? person.HomeCity.Id - 1 : 0;

            if (person.IsMale) { radioButtonMale.Checked = true; }
            else { radioButtonFemale.Checked = true; }

            numStrength.Value = person.Strength;
            numIntelligence.Value = person.Intelligence;
            numAgility.Value = person.Agility;
            numCharisma.Value = person.Charisma;
        }

        private void ShowRaceData()
        {
            if (listRaces.SelectedIndex == -1) { return; }
            
            var race = races[listRaces.SelectedIndex];
            var posHabitatList = race.PositiveHabitats?.Split(',').ToList();
            var negHabitatList = race.NegativeHabitats?.Split(',').ToList();
            textRaceName.Text = race.Name;

            if (posHabitatList != null)
            {
                foreach (var habitat in posHabitatList)
                {
                    var enumValue = Enum.Parse(typeof(Habitat), habitat, true);
                    var index = chkListPositiveHabitats.Items.IndexOf(enumValue);
                    chkListPositiveHabitats.SetItemChecked(index, true);
                }
            }

            if (negHabitatList != null)
            {
                foreach (var habitat in negHabitatList)
                {
                    var enumValue = Enum.Parse(typeof(Habitat), habitat, true);
                    var index = chkListNegativeHabitats.Items.IndexOf(enumValue);
                    chkListNegativeHabitats.SetItemChecked(index, true);
                }
            }
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
            person.SocialStatus = (SocialStatus)comboStatus.SelectedIndex;
            person.HomeCity = cities[comboCities.SelectedIndex];

            ReloadUiData();

            var personRepo = new PersonRepository();
            personRepo.SavePersons(persons);
        }

        private void SaveRaceData()
        {
            var race = races[listRaces.SelectedIndex];

            race.Name = textRaceName.Text;

            var posHabitats = chkListPositiveHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.PositiveHabitats = race.ConvertEnumListToString(posHabitats);
            var negHabitats = chkListNegativeHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.NegativeHabitats = race.ConvertEnumListToString(negHabitats);

            ReloadUiData();

            var raceRepo = new RaceRepository();
            raceRepo.SaveRaces(races);
        }

        private void chkListPositiveHabitats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                chkListNegativeHabitats.SetItemChecked(e.Index, false);
            }
            chkListPositiveHabitats.ClearSelected();
        }

        private void chkListNegativeHabitats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                chkListPositiveHabitats.SetItemChecked(e.Index, false);
            }
            chkListNegativeHabitats.ClearSelected();
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            races.Add(new Race(){ Name = "NewRace" });
            ReloadUiData();
        }

        private void btnSaveRaces_Click(object sender, EventArgs e)
        {
            SaveRaceData();
            LoadFromDatabase();
        }

        private void btnCancelRace_Click(object sender, EventArgs e)
        {
            ShowRaceData();
        }

        private void listRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRaceData();
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
