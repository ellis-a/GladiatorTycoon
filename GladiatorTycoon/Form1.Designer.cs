namespace GladiatorTycoon
{
    partial class Form1
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
            this.listPeople = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSlaves = new System.Windows.Forms.GroupBox();
            this.btnSlaveSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.listBoxOwners = new System.Windows.Forms.ListBox();
            this.chkBoxIsGladiator = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCities = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnNewPerson = new System.Windows.Forms.Button();
            this.btnSavePeople = new System.Windows.Forms.Button();
            this.btnCancelPerson = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCharisma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numAgility = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numIntelligence = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewRace = new System.Windows.Forms.Button();
            this.btnSaveRaces = new System.Windows.Forms.Button();
            this.btnCancelRace = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.chkListNegativeHabitats = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkListPositiveHabitats = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textRaceName = new System.Windows.Forms.TextBox();
            this.listRaces = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSlaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.Location = new System.Drawing.Point(6, 19);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(222, 95);
            this.listPeople.TabIndex = 2;
            this.listPeople.SelectedIndexChanged += new System.EventHandler(this.listPeople_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxSlaves);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboCities);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboStatus);
            this.groupBox1.Controls.Add(this.btnNewPerson);
            this.groupBox1.Controls.Add(this.btnSavePeople);
            this.groupBox1.Controls.Add(this.btnCancelPerson);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numCharisma);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numAgility);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numIntelligence);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numStrength);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboRace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.listPeople);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // groupBoxSlaves
            // 
            this.groupBoxSlaves.Controls.Add(this.btnSlaveSave);
            this.groupBoxSlaves.Controls.Add(this.label16);
            this.groupBoxSlaves.Controls.Add(this.numericUpDown1);
            this.groupBoxSlaves.Controls.Add(this.label15);
            this.groupBoxSlaves.Controls.Add(this.listBoxOwners);
            this.groupBoxSlaves.Controls.Add(this.chkBoxIsGladiator);
            this.groupBoxSlaves.Enabled = false;
            this.groupBoxSlaves.Location = new System.Drawing.Point(6, 315);
            this.groupBoxSlaves.Name = "groupBoxSlaves";
            this.groupBoxSlaves.Size = new System.Drawing.Size(303, 221);
            this.groupBoxSlaves.TabIndex = 28;
            this.groupBoxSlaves.TabStop = false;
            this.groupBoxSlaves.Text = "Slave";
            // 
            // btnSlaveSave
            // 
            this.btnSlaveSave.Location = new System.Drawing.Point(222, 35);
            this.btnSlaveSave.Name = "btnSlaveSave";
            this.btnSlaveSave.Size = new System.Drawing.Size(75, 23);
            this.btnSlaveSave.TabIndex = 33;
            this.btnSlaveSave.Text = "Save";
            this.btnSlaveSave.UseVisualStyleBackColor = true;
            this.btnSlaveSave.Click += new System.EventHandler(this.btnSlaveSave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Loyalty";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 110);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Owner";
            // 
            // listBoxOwners
            // 
            this.listBoxOwners.FormattingEnabled = true;
            this.listBoxOwners.Location = new System.Drawing.Point(7, 35);
            this.listBoxOwners.Name = "listBoxOwners";
            this.listBoxOwners.Size = new System.Drawing.Size(209, 95);
            this.listBoxOwners.TabIndex = 3;
            // 
            // chkBoxIsGladiator
            // 
            this.chkBoxIsGladiator.AutoSize = true;
            this.chkBoxIsGladiator.Location = new System.Drawing.Point(7, 136);
            this.chkBoxIsGladiator.Name = "chkBoxIsGladiator";
            this.chkBoxIsGladiator.Size = new System.Drawing.Size(68, 17);
            this.chkBoxIsGladiator.TabIndex = 0;
            this.chkBoxIsGladiator.Text = "Gladiator";
            this.chkBoxIsGladiator.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Home City";
            // 
            // comboCities
            // 
            this.comboCities.FormattingEnabled = true;
            this.comboCities.Location = new System.Drawing.Point(146, 288);
            this.comboCities.Name = "comboCities";
            this.comboCities.Size = new System.Drawing.Size(163, 21);
            this.comboCities.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Social Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(6, 288);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(134, 21);
            this.comboStatus.TabIndex = 24;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Location = new System.Drawing.Point(234, 48);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(75, 23);
            this.btnNewPerson.TabIndex = 23;
            this.btnNewPerson.Text = "New";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // btnSavePeople
            // 
            this.btnSavePeople.Location = new System.Drawing.Point(234, 19);
            this.btnSavePeople.Name = "btnSavePeople";
            this.btnSavePeople.Size = new System.Drawing.Size(75, 23);
            this.btnSavePeople.TabIndex = 22;
            this.btnSavePeople.Text = "Save";
            this.btnSavePeople.UseVisualStyleBackColor = true;
            this.btnSavePeople.Click += new System.EventHandler(this.btnSavePeople_Click);
            // 
            // btnCancelPerson
            // 
            this.btnCancelPerson.Location = new System.Drawing.Point(234, 77);
            this.btnCancelPerson.Name = "btnCancelPerson";
            this.btnCancelPerson.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPerson.TabIndex = 21;
            this.btnCancelPerson.Text = "Cancel";
            this.btnCancelPerson.UseVisualStyleBackColor = true;
            this.btnCancelPerson.Click += new System.EventHandler(this.btnCancelPerson_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Base Stats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Charisma";
            // 
            // numCharisma
            // 
            this.numCharisma.Location = new System.Drawing.Point(193, 243);
            this.numCharisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCharisma.Name = "numCharisma";
            this.numCharisma.Size = new System.Drawing.Size(48, 20);
            this.numCharisma.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Agility";
            // 
            // numAgility
            // 
            this.numAgility.Location = new System.Drawing.Point(139, 243);
            this.numAgility.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAgility.Name = "numAgility";
            this.numAgility.Size = new System.Drawing.Size(48, 20);
            this.numAgility.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Intellect";
            // 
            // numIntelligence
            // 
            this.numIntelligence.Location = new System.Drawing.Point(85, 243);
            this.numIntelligence.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numIntelligence.Name = "numIntelligence";
            this.numIntelligence.Size = new System.Drawing.Size(48, 20);
            this.numIntelligence.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sex";
            // 
            // numStrength
            // 
            this.numStrength.Location = new System.Drawing.Point(31, 243);
            this.numStrength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numStrength.Name = "numStrength";
            this.numStrength.Size = new System.Drawing.Size(48, 20);
            this.numStrength.TabIndex = 11;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(229, 181);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(175, 181);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Race";
            // 
            // comboRace
            // 
            this.comboRace.FormattingEnabled = true;
            this.comboRace.Location = new System.Drawing.Point(6, 180);
            this.comboRace.Name = "comboRace";
            this.comboRace.Size = new System.Drawing.Size(134, 21);
            this.comboRace.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(146, 137);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(163, 20);
            this.textLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(6, 137);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(134, 20);
            this.textFirstName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewRace);
            this.groupBox2.Controls.Add(this.btnSaveRaces);
            this.groupBox2.Controls.Add(this.btnCancelRace);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.chkListNegativeHabitats);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.chkListPositiveHabitats);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textRaceName);
            this.groupBox2.Controls.Add(this.listRaces);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 346);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Races";
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(241, 48);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(75, 23);
            this.btnNewRace.TabIndex = 37;
            this.btnNewRace.Text = "New";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // btnSaveRaces
            // 
            this.btnSaveRaces.Location = new System.Drawing.Point(241, 19);
            this.btnSaveRaces.Name = "btnSaveRaces";
            this.btnSaveRaces.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRaces.TabIndex = 36;
            this.btnSaveRaces.Text = "Save";
            this.btnSaveRaces.UseVisualStyleBackColor = true;
            this.btnSaveRaces.Click += new System.EventHandler(this.btnSaveRaces_Click);
            // 
            // btnCancelRace
            // 
            this.btnCancelRace.Location = new System.Drawing.Point(241, 77);
            this.btnCancelRace.Name = "btnCancelRace";
            this.btnCancelRace.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRace.TabIndex = 35;
            this.btnCancelRace.Text = "Cancel";
            this.btnCancelRace.UseVisualStyleBackColor = true;
            this.btnCancelRace.Click += new System.EventHandler(this.btnCancelRace_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Negative Habitats";
            // 
            // chkListNegativeHabitats
            // 
            this.chkListNegativeHabitats.CheckOnClick = true;
            this.chkListNegativeHabitats.FormattingEnabled = true;
            this.chkListNegativeHabitats.Location = new System.Drawing.Point(165, 198);
            this.chkListNegativeHabitats.Name = "chkListNegativeHabitats";
            this.chkListNegativeHabitats.Size = new System.Drawing.Size(151, 139);
            this.chkListNegativeHabitats.TabIndex = 33;
            this.chkListNegativeHabitats.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListNegativeHabitats_ItemCheck);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Positive Habitats";
            // 
            // chkListPositiveHabitats
            // 
            this.chkListPositiveHabitats.CheckOnClick = true;
            this.chkListPositiveHabitats.FormattingEnabled = true;
            this.chkListPositiveHabitats.Location = new System.Drawing.Point(6, 198);
            this.chkListPositiveHabitats.Name = "chkListPositiveHabitats";
            this.chkListPositiveHabitats.Size = new System.Drawing.Size(150, 139);
            this.chkListPositiveHabitats.TabIndex = 31;
            this.chkListPositiveHabitats.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListPositiveHabitats_ItemCheck);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Name";
            // 
            // textRaceName
            // 
            this.textRaceName.Location = new System.Drawing.Point(6, 152);
            this.textRaceName.Name = "textRaceName";
            this.textRaceName.Size = new System.Drawing.Size(134, 20);
            this.textRaceName.TabIndex = 29;
            // 
            // listRaces
            // 
            this.listRaces.FormattingEnabled = true;
            this.listRaces.Location = new System.Drawing.Point(6, 19);
            this.listRaces.Name = "listRaces";
            this.listRaces.Size = new System.Drawing.Size(229, 108);
            this.listRaces.TabIndex = 28;
            this.listRaces.SelectedIndexChanged += new System.EventHandler(this.listRaces_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Database Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSlaves.ResumeLayout(false);
            this.groupBoxSlaves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRace;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCharisma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAgility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numIntelligence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSavePeople;
        private System.Windows.Forms.Button btnCancelPerson;
        private System.Windows.Forms.Button btnNewPerson;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCities;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listRaces;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRaceName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox chkListPositiveHabitats;
        private System.Windows.Forms.Button btnNewRace;
        private System.Windows.Forms.Button btnSaveRaces;
        private System.Windows.Forms.Button btnCancelRace;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox chkListNegativeHabitats;
        private System.Windows.Forms.GroupBox groupBoxSlaves;
        private System.Windows.Forms.ListBox listBoxOwners;
        private System.Windows.Forms.CheckBox chkBoxIsGladiator;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSlaveSave;
    }
}

