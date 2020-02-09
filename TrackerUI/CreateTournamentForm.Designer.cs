namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentHeader = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.ComboBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entyFeeValue = new System.Windows.Forms.ComboBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.TaemsLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deletSelectedPrizebutton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentHeader
            // 
            this.createTournamentHeader.AutoSize = true;
            this.createTournamentHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTournamentHeader.Location = new System.Drawing.Point(12, 9);
            this.createTournamentHeader.Name = "createTournamentHeader";
            this.createTournamentHeader.Size = new System.Drawing.Size(317, 50);
            this.createTournamentHeader.TabIndex = 1;
            this.createTournamentHeader.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.FormattingEnabled = true;
            this.tournamentNameValue.Location = new System.Drawing.Point(21, 103);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(282, 38);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 63);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(225, 37);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entyFeeValue
            // 
            this.entyFeeValue.FormattingEnabled = true;
            this.entyFeeValue.Location = new System.Drawing.Point(146, 163);
            this.entyFeeValue.Name = "entyFeeValue";
            this.entyFeeValue.Size = new System.Drawing.Size(157, 38);
            this.entyFeeValue.TabIndex = 12;
            this.entyFeeValue.Text = "0";
            this.entyFeeValue.SelectedIndexChanged += new System.EventHandler(this.entyFeeValue_SelectedIndexChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.entryFeeLabel.Location = new System.Drawing.Point(14, 161);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(124, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdownComboBox
            // 
            this.selectTeamDropdownComboBox.FormattingEnabled = true;
            this.selectTeamDropdownComboBox.Location = new System.Drawing.Point(21, 253);
            this.selectTeamDropdownComboBox.Name = "selectTeamDropdownComboBox";
            this.selectTeamDropdownComboBox.Size = new System.Drawing.Size(282, 38);
            this.selectTeamDropdownComboBox.TabIndex = 14;
            this.selectTeamDropdownComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropdownComboBox_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectTeamLabel.Location = new System.Drawing.Point(14, 213);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(150, 37);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.selectTeamLabel_Click);
            // 
            // createNewTeamlinkLabel
            // 
            this.createNewTeamlinkLabel.AutoSize = true;
            this.createNewTeamlinkLabel.Location = new System.Drawing.Point(182, 220);
            this.createNewTeamlinkLabel.Name = "createNewTeamlinkLabel";
            this.createNewTeamlinkLabel.Size = new System.Drawing.Size(121, 30);
            this.createNewTeamlinkLabel.TabIndex = 15;
            this.createNewTeamlinkLabel.TabStop = true;
            this.createNewTeamlinkLabel.Text = "Create New";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addTeamButton.Location = new System.Drawing.Point(83, 297);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(143, 51);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createPrizebutton.Location = new System.Drawing.Point(83, 371);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(143, 51);
            this.createPrizebutton.TabIndex = 17;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerListBox
            // 
            this.tournamentPlayerListBox.FormattingEnabled = true;
            this.tournamentPlayerListBox.ItemHeight = 30;
            this.tournamentPlayerListBox.Location = new System.Drawing.Point(374, 103);
            this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            this.tournamentPlayerListBox.Size = new System.Drawing.Size(257, 124);
            this.tournamentPlayerListBox.TabIndex = 18;
            // 
            // TaemsLabel
            // 
            this.TaemsLabel.AutoSize = true;
            this.TaemsLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.TaemsLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TaemsLabel.Location = new System.Drawing.Point(367, 63);
            this.TaemsLabel.Name = "TaemsLabel";
            this.TaemsLabel.Size = new System.Drawing.Size(175, 37);
            this.TaemsLabel.TabIndex = 19;
            this.TaemsLabel.Text = "Teams/Players";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.prizesLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizesLabel.Location = new System.Drawing.Point(367, 257);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(84, 37);
            this.prizesLabel.TabIndex = 21;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(374, 297);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(257, 124);
            this.prizesListBox.TabIndex = 20;
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(637, 131);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(143, 80);
            this.deleteSelectedPlayerButton.TabIndex = 22;
            this.deleteSelectedPlayerButton.Text = "Delete Selectd";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deletSelectedPrizebutton
            // 
            this.deletSelectedPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletSelectedPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletSelectedPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletSelectedPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletSelectedPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletSelectedPrizebutton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deletSelectedPrizebutton.Location = new System.Drawing.Point(637, 328);
            this.deletSelectedPrizebutton.Name = "deletSelectedPrizebutton";
            this.deletSelectedPrizebutton.Size = new System.Drawing.Size(143, 75);
            this.deletSelectedPrizebutton.TabIndex = 23;
            this.deletSelectedPrizebutton.Text = "Delet Selected";
            this.deletSelectedPrizebutton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTournamentButton.Location = new System.Drawing.Point(241, 476);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(280, 51);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 539);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletSelectedPrizebutton);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.TaemsLabel);
            this.Controls.Add(this.tournamentPlayerListBox);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamlinkLabel);
            this.Controls.Add(this.selectTeamDropdownComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entyFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = " Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentHeader;
        private System.Windows.Forms.ComboBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.ComboBox entyFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdownComboBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamlinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizebutton;
        private System.Windows.Forms.ListBox tournamentPlayerListBox;
        private System.Windows.Forms.Label TaemsLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deletSelectedPrizebutton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}