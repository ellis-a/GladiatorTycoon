namespace GladiatorTycoon.Forms
{
    partial class BodyPartForm
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
            this.textRaceName = new System.Windows.Forms.TextBox();
            this.listRaces = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.chkListPositiveHabitats = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(438, 41);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(75, 23);
            this.btnNewRace.TabIndex = 47;
            this.btnNewRace.Text = "New";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // btnSaveRaces
            // 
            this.btnSaveRaces.Location = new System.Drawing.Point(438, 12);
            this.btnSaveRaces.Name = "btnSaveRaces";
            this.btnSaveRaces.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRaces.TabIndex = 46;
            this.btnSaveRaces.Text = "Save";
            this.btnSaveRaces.UseVisualStyleBackColor = true;
            this.btnSaveRaces.Click += new System.EventHandler(this.btnSaveRaces_Click);
            // 
            // btnCloseRace
            // 
            this.btnCloseRace.Location = new System.Drawing.Point(438, 70);
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
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Positive Habitats";
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
            // textRaceName
            // 
            this.textRaceName.Location = new System.Drawing.Point(12, 145);
            this.textRaceName.Name = "textRaceName";
            this.textRaceName.Size = new System.Drawing.Size(150, 20);
            this.textRaceName.TabIndex = 39;
            // 
            // listRaces
            // 
            this.listRaces.FormattingEnabled = true;
            this.listRaces.Location = new System.Drawing.Point(12, 12);
            this.listRaces.Name = "listRaces";
            this.listRaces.Size = new System.Drawing.Size(150, 108);
            this.listRaces.TabIndex = 38;
            this.listRaces.SelectedIndexChanged += new System.EventHandler(this.listRaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Body Parts";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(357, 12);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 50;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // chkListPositiveHabitats
            // 
            this.chkListPositiveHabitats.CheckOnClick = true;
            this.chkListPositiveHabitats.FormattingEnabled = true;
            this.chkListPositiveHabitats.Location = new System.Drawing.Point(12, 191);
            this.chkListPositiveHabitats.Name = "chkListPositiveHabitats";
            this.chkListPositiveHabitats.Size = new System.Drawing.Size(150, 49);
            this.chkListPositiveHabitats.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 51;
            // 
            // BodyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.btnSaveRaces);
            this.Controls.Add(this.btnCloseRace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkListPositiveHabitats);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textRaceName);
            this.Controls.Add(this.listRaces);
            this.Name = "BodyPartForm";
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
        private System.Windows.Forms.TextBox textRaceName;
        private System.Windows.Forms.ListBox listRaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.CheckedListBox chkListPositiveHabitats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}