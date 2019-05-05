namespace GladiatorTycoon
{
    partial class RaceForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.chkListNegativeHabitats = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkListPositiveHabitats = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textRaceName = new System.Windows.Forms.TextBox();
            this.listRaces = new System.Windows.Forms.ListBox();
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
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Negative Habitats";
            // 
            // chkListNegativeHabitats
            // 
            this.chkListNegativeHabitats.CheckOnClick = true;
            this.chkListNegativeHabitats.FormattingEnabled = true;
            this.chkListNegativeHabitats.Location = new System.Drawing.Point(171, 191);
            this.chkListNegativeHabitats.Name = "chkListNegativeHabitats";
            this.chkListNegativeHabitats.Size = new System.Drawing.Size(151, 139);
            this.chkListNegativeHabitats.TabIndex = 43;
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
            // chkListPositiveHabitats
            // 
            this.chkListPositiveHabitats.CheckOnClick = true;
            this.chkListPositiveHabitats.FormattingEnabled = true;
            this.chkListPositiveHabitats.Location = new System.Drawing.Point(12, 191);
            this.chkListPositiveHabitats.Name = "chkListPositiveHabitats";
            this.chkListPositiveHabitats.Size = new System.Drawing.Size(150, 139);
            this.chkListPositiveHabitats.TabIndex = 41;
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
            this.textRaceName.Size = new System.Drawing.Size(134, 20);
            this.textRaceName.TabIndex = 39;
            // 
            // listRaces
            // 
            this.listRaces.FormattingEnabled = true;
            this.listRaces.Location = new System.Drawing.Point(12, 12);
            this.listRaces.Name = "listRaces";
            this.listRaces.Size = new System.Drawing.Size(229, 108);
            this.listRaces.TabIndex = 38;
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 343);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.btnSaveRaces);
            this.Controls.Add(this.btnCloseRace);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkListNegativeHabitats);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkListPositiveHabitats);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textRaceName);
            this.Controls.Add(this.listRaces);
            this.Name = "RaceForm";
            this.Text = "RaceForm";
            this.Load += new System.EventHandler(this.RaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewRace;
        private System.Windows.Forms.Button btnSaveRaces;
        private System.Windows.Forms.Button btnCloseRace;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox chkListNegativeHabitats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox chkListPositiveHabitats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRaceName;
        private System.Windows.Forms.ListBox listRaces;
    }
}