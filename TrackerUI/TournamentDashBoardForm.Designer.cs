namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.dashboardHeader = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboardHeader
            // 
            this.dashboardHeader.AutoSize = true;
            this.dashboardHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dashboardHeader.Location = new System.Drawing.Point(103, 38);
            this.dashboardHeader.Name = "dashboardHeader";
            this.dashboardHeader.Size = new System.Drawing.Size(385, 50);
            this.dashboardHeader.TabIndex = 4;
            this.dashboardHeader.Text = "Tournament Dashboard";
            this.dashboardHeader.Click += new System.EventHandler(this.dashboardHeader_Click);
            // 
            // loadExistingTournamentDropdownComboBox
            // 
            this.loadExistingTournamentDropdownComboBox.FormattingEnabled = true;
            this.loadExistingTournamentDropdownComboBox.Location = new System.Drawing.Point(93, 163);
            this.loadExistingTournamentDropdownComboBox.Name = "loadExistingTournamentDropdownComboBox";
            this.loadExistingTournamentDropdownComboBox.Size = new System.Drawing.Size(404, 38);
            this.loadExistingTournamentDropdownComboBox.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(144, 123);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(303, 37);
            this.loadExistingTournamentLabel.TabIndex = 19;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTournamentButton.Location = new System.Drawing.Point(162, 307);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(267, 82);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loadTournamentButton.Location = new System.Drawing.Point(178, 207);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(235, 50);
            this.loadTournamentButton.TabIndex = 28;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 417);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropdownComboBox);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.dashboardHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardHeader;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropdownComboBox;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button loadTournamentButton;
    }
}