namespace GladiatorTycoon.Forms
{
    partial class PersonForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.comboCities = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnNewPerson = new System.Windows.Forms.Button();
            this.btnSavePeople = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCharisma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numSkill = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numWit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.listPeople = new System.Windows.Forms.ListBox();
            this.btnEditRaces = new System.Windows.Forms.Button();
            this.btnEditCities = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Home City";
            // 
            // comboCities
            // 
            this.comboCities.FormattingEnabled = true;
            this.comboCities.Location = new System.Drawing.Point(12, 321);
            this.comboCities.Name = "comboCities";
            this.comboCities.Size = new System.Drawing.Size(222, 21);
            this.comboCities.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Social Status";
            // 
            // comboStatus
            // 
            this.comboStatus.Enabled = false;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(12, 281);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(163, 21);
            this.comboStatus.TabIndex = 51;
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Location = new System.Drawing.Point(321, 41);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(75, 23);
            this.btnNewPerson.TabIndex = 50;
            this.btnNewPerson.Text = "New";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // btnSavePeople
            // 
            this.btnSavePeople.Location = new System.Drawing.Point(321, 12);
            this.btnSavePeople.Name = "btnSavePeople";
            this.btnSavePeople.Size = new System.Drawing.Size(75, 23);
            this.btnSavePeople.TabIndex = 49;
            this.btnSavePeople.Text = "Save";
            this.btnSavePeople.UseVisualStyleBackColor = true;
            this.btnSavePeople.Click += new System.EventHandler(this.btnSavePeople_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Base Stats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Charisma";
            // 
            // numCharisma
            // 
            this.numCharisma.Location = new System.Drawing.Point(199, 236);
            this.numCharisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCharisma.Name = "numCharisma";
            this.numCharisma.Size = new System.Drawing.Size(48, 20);
            this.numCharisma.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Skill";
            // 
            // numSkill
            // 
            this.numSkill.Location = new System.Drawing.Point(145, 236);
            this.numSkill.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSkill.Name = "numSkill";
            this.numSkill.Size = new System.Drawing.Size(48, 20);
            this.numSkill.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Wits";
            // 
            // numWit
            // 
            this.numWit.Location = new System.Drawing.Point(91, 236);
            this.numWit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWit.Name = "numWit";
            this.numWit.Size = new System.Drawing.Size(48, 20);
            this.numWit.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sex";
            // 
            // numPower
            // 
            this.numPower.Location = new System.Drawing.Point(37, 236);
            this.numPower.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPower.Name = "numPower";
            this.numPower.Size = new System.Drawing.Size(48, 20);
            this.numPower.TabIndex = 38;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(375, 131);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 37;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(321, 131);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 36;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Race";
            // 
            // comboRace
            // 
            this.comboRace.FormattingEnabled = true;
            this.comboRace.Location = new System.Drawing.Point(12, 173);
            this.comboRace.Name = "comboRace";
            this.comboRace.Size = new System.Drawing.Size(222, 21);
            this.comboRace.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(152, 130);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(163, 20);
            this.textLastName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(12, 130);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(134, 20);
            this.textFirstName.TabIndex = 30;
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.Location = new System.Drawing.Point(12, 12);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(303, 95);
            this.listPeople.TabIndex = 29;
            // 
            // btnEditRaces
            // 
            this.btnEditRaces.Location = new System.Drawing.Point(240, 171);
            this.btnEditRaces.Name = "btnEditRaces";
            this.btnEditRaces.Size = new System.Drawing.Size(75, 23);
            this.btnEditRaces.TabIndex = 55;
            this.btnEditRaces.Text = "Edit Races";
            this.btnEditRaces.UseVisualStyleBackColor = true;
            this.btnEditRaces.Click += new System.EventHandler(this.btnEditRaces_Click);
            // 
            // btnEditCities
            // 
            this.btnEditCities.Location = new System.Drawing.Point(240, 319);
            this.btnEditCities.Name = "btnEditCities";
            this.btnEditCities.Size = new System.Drawing.Size(75, 23);
            this.btnEditCities.TabIndex = 56;
            this.btnEditCities.Text = "Edit Cities";
            this.btnEditCities.UseVisualStyleBackColor = true;
            this.btnEditCities.Click += new System.EventHandler(this.btnEditCities_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(321, 70);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 57;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 485);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.btnEditCities);
            this.Controls.Add(this.btnEditRaces);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboCities);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.btnNewPerson);
            this.Controls.Add(this.btnSavePeople);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numCharisma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSkill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numWit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPower);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.listPeople);
            this.Name = "PersonForm";
            this.Text = "Database Interface";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCities;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnNewPerson;
        private System.Windows.Forms.Button btnSavePeople;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCharisma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSkill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.Button btnEditRaces;
        private System.Windows.Forms.Button btnEditCities;
        private System.Windows.Forms.Button GenerateButton;
    }
}

