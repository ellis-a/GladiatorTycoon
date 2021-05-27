namespace Forms
{
    partial class CityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewRace = new System.Windows.Forms.Button();
            this.btnSaveRaces = new System.Windows.Forms.Button();
            this.btnCloseRace = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textCityName = new System.Windows.Forms.TextBox();
            this.listCities = new System.Windows.Forms.ListBox();
            this.comboHabitats = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(247, 41);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(75, 23);
            this.btnNewRace.TabIndex = 47;
            this.btnNewRace.Text = "New";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewCity_Click);
            // 
            // btnSaveRaces
            // 
            this.btnSaveRaces.Location = new System.Drawing.Point(247, 12);
            this.btnSaveRaces.Name = "btnSaveRaces";
            this.btnSaveRaces.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRaces.TabIndex = 46;
            this.btnSaveRaces.Text = "Save";
            this.btnSaveRaces.UseVisualStyleBackColor = true;
            this.btnSaveRaces.Click += new System.EventHandler(this.btnSaveRaces_Click);
            // 
            // btnCloseRace
            // 
            this.btnCloseRace.Location = new System.Drawing.Point(247, 70);
            this.btnCloseRace.Name = "btnCloseRace";
            this.btnCloseRace.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRace.TabIndex = 45;
            this.btnCloseRace.Text = "Close";
            this.btnCloseRace.UseVisualStyleBackColor = true;
            this.btnCloseRace.Click += new System.EventHandler(this.btnCloseRace_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Habitat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Name";
            // 
            // textCityName
            // 
            this.textCityName.Location = new System.Drawing.Point(12, 145);
            this.textCityName.Name = "textCityName";
            this.textCityName.Size = new System.Drawing.Size(229, 20);
            this.textCityName.TabIndex = 39;
            // 
            // listCities
            // 
            this.listCities.FormattingEnabled = true;
            this.listCities.Location = new System.Drawing.Point(12, 12);
            this.listCities.Name = "listCities";
            this.listCities.Size = new System.Drawing.Size(229, 108);
            this.listCities.TabIndex = 38;
            // 
            // comboHabitats
            // 
            this.comboHabitats.FormattingEnabled = true;
            this.comboHabitats.Location = new System.Drawing.Point(12, 190);
            this.comboHabitats.Name = "comboHabitats";
            this.comboHabitats.Size = new System.Drawing.Size(229, 21);
            this.comboHabitats.TabIndex = 54;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 343);
            this.Controls.Add(this.comboHabitats);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.btnSaveRaces);
            this.Controls.Add(this.btnCloseRace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textCityName);
            this.Controls.Add(this.listCities);
            this.Name = "CityForm";
            this.Text = "RaceForm";
            this.Load += new System.EventHandler(this.RaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewRace;
        private System.Windows.Forms.Button btnSaveRaces;
        private System.Windows.Forms.Button btnCloseRace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCityName;
        private System.Windows.Forms.ListBox listCities;
        private System.Windows.Forms.ComboBox comboHabitats;
    }
}