using GladiatorTycoon.Enums;
using GladiatorTycoon.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GladiatorTycoon
{
    public partial class RaceForm : Form
    {
        private List<Race> races;

        public RaceForm()
        {
            InitializeComponent();
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            RacesGroupBox();
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

        private void btnSaveRaces_Click(object sender, EventArgs e)
        {
            SaveRaceData();
            //LoadFromDatabase();
        }

        private void btnCancelRace_Click(object sender, EventArgs e)
        {
            ShowRaceData();
        }

        private void listRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRaceData();
        }

        private void SaveRaceData()
        {
            var race = races[listRaces.SelectedIndex];

            race.Name = textRaceName.Text;

            var posHabitats = chkListPositiveHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.PositiveHabitats = race.ConvertEnumListToString(posHabitats);
            var negHabitats = chkListNegativeHabitats.CheckedItems.Cast<Habitat>().ToList();
            race.NegativeHabitats = race.ConvertEnumListToString(negHabitats);

            //ReloadUiData();

            //var raceRepo = new RaceRepository();
            //raceRepo.SaveRaces(races);
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
    }
}
