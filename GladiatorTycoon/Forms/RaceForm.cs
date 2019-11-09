using GladiatorTycoon.Enums;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using GladiatorTycoon.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GladiatorTycoon.Forms
{
    public partial class RaceForm : Form
    {
        private RaceService _raceService;
        private PersonNameService _personNameService;
        private List<Race> _races;
        private List<RaceBodyPart> _currentRaceParts;

        public RaceForm(IRaceRepository raceRepo, IPersonNameRepository personNameRepo)
        {
            InitializeComponent();
            _raceService = new RaceService(raceRepo, personNameRepo);
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            LoadUiData();
        }

        private void LoadUiData()
        {
            _currentRaceParts = new List<RaceBodyPart>();
            _races = _raceService.GetAll();

            ResetRaces();
            LoadPosHabitats();
            LoadNegHabitats();
        }

        private void ResetBodyParts()
        {
            listParts.Items.Clear();

            foreach (var part in _currentRaceParts)
            {
                listParts.Items.Add($"{part.Name} ({part.DevName})");
            }
        }

        private void LoadNegHabitats()
        {
            chkListNegativeHabitats.Items.Clear();
            foreach (var habitat in (Habitat[])Enum.GetValues(typeof(Habitat)))
            {
                chkListNegativeHabitats.Items.Add(habitat);
            }
        }

        private void LoadPosHabitats()
        {
            chkListPositiveHabitats.Items.Clear();
            foreach (var habitat in (Habitat[])Enum.GetValues(typeof(Habitat)))
            {
                chkListPositiveHabitats.Items.Add(habitat);
            }
        }

        private void ResetRaces()
        {
            listRaces.Items.Clear();
            foreach (var race in _races)
            {
                listRaces.Items.Add(race.Name);
            }
        }

        private void ShowRaceData()
        {
            if (listRaces.SelectedIndex == -1) { return; }

            var race = _races[listRaces.SelectedIndex];
            var posHabitatList = race.PositiveHabitats?.Split(',').ToList();
            var negHabitatList = race.NegativeHabitats?.Split(',').ToList();
            textRaceName.Text = race.Name;

            _currentRaceParts = race.BodyParts;
            if (_currentRaceParts == null)
            {
                _currentRaceParts = new List<RaceBodyPart>();
            }

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

        private void SaveRacesButton_Click(object sender, EventArgs e)
        {
            SaveRaceData();
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            _races = _raceService.GetAll();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRaceData();
        }

        private void SaveRaceData()
        {
            var race = _races[listRaces.SelectedIndex];

            race.Name = textRaceName.Text;

            var posHabitats = chkListPositiveHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.PositiveHabitats = race.ConvertEnumListToString(posHabitats);
            var negHabitats = chkListNegativeHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.NegativeHabitats = race.ConvertEnumListToString(negHabitats);

            ResetRaces();
            _raceService.Update(race);
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

        private void NewRaceButton_Click(object sender, EventArgs e)
        {
            var newRace = new Race() { Name = Guid.NewGuid().ToString() };
            _raceService.Create(newRace);
            LoadUiData();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
