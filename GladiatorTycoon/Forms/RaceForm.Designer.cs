﻿namespace Forms
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
            this.NewRaceButton = new System.Windows.Forms.Button();
            this.SaveRacesButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.chkListNegativeHabitats = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkListPositiveHabitats = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textRaceName = new System.Windows.Forms.TextBox();
            this.listRaces = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NewRaceButton
            // 
            this.NewRaceButton.Location = new System.Drawing.Point(247, 41);
            this.NewRaceButton.Name = "NewRaceButton";
            this.NewRaceButton.Size = new System.Drawing.Size(75, 23);
            this.NewRaceButton.TabIndex = 47;
            this.NewRaceButton.Text = "New";
            this.NewRaceButton.UseVisualStyleBackColor = true;
            this.NewRaceButton.Click += new System.EventHandler(this.NewRaceButton_Click);
            // 
            // SaveRacesButton
            // 
            this.SaveRacesButton.Location = new System.Drawing.Point(247, 12);
            this.SaveRacesButton.Name = "SaveRacesButton";
            this.SaveRacesButton.Size = new System.Drawing.Size(75, 23);
            this.SaveRacesButton.TabIndex = 46;
            this.SaveRacesButton.Text = "Save";
            this.SaveRacesButton.UseVisualStyleBackColor = true;
            this.SaveRacesButton.Click += new System.EventHandler(this.SaveRacesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(247, 70);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 45;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.chkListNegativeHabitats.Location = new System.Drawing.Point(171, 190);
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
            this.textRaceName.Size = new System.Drawing.Size(150, 20);
            this.textRaceName.TabIndex = 39;
            // 
            // listRaces
            // 
            this.listRaces.FormattingEnabled = true;
            this.listRaces.Location = new System.Drawing.Point(12, 12);
            this.listRaces.Name = "listRaces";
            this.listRaces.Size = new System.Drawing.Size(229, 108);
            this.listRaces.TabIndex = 38;
            this.listRaces.SelectedIndexChanged += new System.EventHandler(this.listRaces_SelectedIndexChanged);
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 343);
            this.Controls.Add(this.NewRaceButton);
            this.Controls.Add(this.SaveRacesButton);
            this.Controls.Add(this.CloseButton);
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

        private System.Windows.Forms.Button NewRaceButton;
        private System.Windows.Forms.Button SaveRacesButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox chkListNegativeHabitats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox chkListPositiveHabitats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRaceName;
        private System.Windows.Forms.ListBox listRaces;
    }
}