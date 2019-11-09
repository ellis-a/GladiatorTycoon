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
    public partial class BodyPartForm : Form
    {
        private RaceService _raceService;
        private List<Race> _races;
        private List<RaceBodyPart> _currentRaceParts;

        public BodyPartForm(IRaceRepository raceRepo, IPersonNameRepository personNameRepo)
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
        }

        private void ResetBodyParts()
        {

        }

        private void btnSaveRaces_Click(object sender, EventArgs e)
        {
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            _races = _raceService.GetAll();
        }

        private void btnCloseRace_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            var newRace = new Race() { Name = Guid.NewGuid().ToString() };
            _raceService.Create(newRace);
            LoadUiData();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
