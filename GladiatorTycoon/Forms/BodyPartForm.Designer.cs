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
            this.label12 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PartsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DevNameTextBox = new System.Windows.Forms.TextBox();
            this.ActionsListBox = new System.Windows.Forms.CheckedListBox();
            this.PartTypeListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(243, 41);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(75, 23);
            this.btnNewRace.TabIndex = 47;
            this.btnNewRace.Text = "New";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // btnSaveRaces
            // 
            this.btnSaveRaces.Location = new System.Drawing.Point(243, 12);
            this.btnSaveRaces.Name = "btnSaveRaces";
            this.btnSaveRaces.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRaces.TabIndex = 46;
            this.btnSaveRaces.Text = "Save";
            this.btnSaveRaces.UseVisualStyleBackColor = true;
            this.btnSaveRaces.Click += new System.EventHandler(this.btnSaveRaces_Click);
            // 
            // btnCloseRace
            // 
            this.btnCloseRace.Location = new System.Drawing.Point(243, 70);
            this.btnCloseRace.Name = "btnCloseRace";
            this.btnCloseRace.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRace.TabIndex = 45;
            this.btnCloseRace.Text = "Close";
            this.btnCloseRace.UseVisualStyleBackColor = true;
            this.btnCloseRace.Click += new System.EventHandler(this.btnCloseRace_Click);
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
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 145);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 39;
            // 
            // PartsListBox
            // 
            this.PartsListBox.FormattingEnabled = true;
            this.PartsListBox.Location = new System.Drawing.Point(12, 12);
            this.PartsListBox.Name = "PartsListBox";
            this.PartsListBox.Size = new System.Drawing.Size(214, 108);
            this.PartsListBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Dev Name";
            // 
            // DevNameTextBox
            // 
            this.DevNameTextBox.Location = new System.Drawing.Point(168, 145);
            this.DevNameTextBox.Name = "DevNameTextBox";
            this.DevNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.DevNameTextBox.TabIndex = 51;
            // 
            // ActionsListBox
            // 
            this.ActionsListBox.CheckOnClick = true;
            this.ActionsListBox.FormattingEnabled = true;
            this.ActionsListBox.Location = new System.Drawing.Point(12, 192);
            this.ActionsListBox.Name = "ActionsListBox";
            this.ActionsListBox.Size = new System.Drawing.Size(150, 139);
            this.ActionsListBox.TabIndex = 53;
            // 
            // PartTypeListBox
            // 
            this.PartTypeListBox.CheckOnClick = true;
            this.PartTypeListBox.FormattingEnabled = true;
            this.PartTypeListBox.Location = new System.Drawing.Point(168, 192);
            this.PartTypeListBox.Name = "PartTypeListBox";
            this.PartTypeListBox.Size = new System.Drawing.Size(150, 139);
            this.PartTypeListBox.TabIndex = 54;
            // 
            // BodyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 343);
            this.Controls.Add(this.PartTypeListBox);
            this.Controls.Add(this.ActionsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevNameTextBox);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.btnSaveRaces);
            this.Controls.Add(this.btnCloseRace);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PartsListBox);
            this.Name = "BodyPartForm";
            this.Text = "Body Parts";
            this.Load += new System.EventHandler(this.RaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewRace;
        private System.Windows.Forms.Button btnSaveRaces;
        private System.Windows.Forms.Button btnCloseRace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox PartsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DevNameTextBox;
        private System.Windows.Forms.CheckedListBox ActionsListBox;
        private System.Windows.Forms.CheckedListBox PartTypeListBox;
    }
}