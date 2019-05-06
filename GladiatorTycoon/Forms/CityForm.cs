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
    public partial class CityForm : Form
    {
        private CityService _cityService;
        private List<City> _cities;

        public CityForm(ICityRepository cityRepo)
        {
            InitializeComponent();
            _cityService = new CityService(cityRepo);
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            ReloadUiData();
        }

        private void ReloadUiData()
        {
            _cities = _cityService.GetAll();

            ResetRaces();
            foreach (var habitat in (Habitat[])Enum.GetValues(typeof(Habitat)))
            {
                comboHabitats.Items.Add(habitat);
            }
        }

        private void ResetRaces()
        {
            listCities.Items.Clear();
            foreach (var city in _cities)
            {
                listCities.Items.Add(city.Name);
            }
        }

        private void ShowCityData()
        {
            if (listCities.SelectedIndex == -1) { return; }

            var city = _cities[listCities.SelectedIndex];
            textCityName.Text = city.Name;

        }

        private void btnSaveRaces_Click(object sender, EventArgs e)
        {
            SaveCityData();
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            _cities = _cityService.GetAll();
        }

        private void btnCloseRace_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCityData();
        }

        private void SaveCityData()
        {
            var city = _cities[listCities.SelectedIndex];

            city.Name = textCityName.Text;
            city.Habitat = Helper.ParseObjectToEnum<Habitat>(comboHabitats.SelectedItem);

            ResetRaces();
            _cityService.Update(city);
        }

        private void btnNewCity_Click(object sender, EventArgs e)
        {
            var newCity = new City() { Name = Guid.NewGuid().ToString() };
            _cityService.Create(newCity);
            ReloadUiData();
        }
    }
}
