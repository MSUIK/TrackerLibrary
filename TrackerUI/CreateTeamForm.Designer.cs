namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.createTeamHeader = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.ComboBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailAddrssValue = new System.Windows.Forms.TextBox();
            this.emailAddressLable = new System.Windows.Forms.Label();
            this.mobileNumberValue = new System.Windows.Forms.TextBox();
            this.mobileNumberLable = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamHeader
            // 
            this.createTeamHeader.AutoSize = true;
            this.createTeamHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTeamHeader.Location = new System.Drawing.Point(12, 9);
            this.createTeamHeader.Name = "createTeamHeader";
            this.createTeamHeader.Size = new System.Drawing.Size(213, 50);
            this.createTeamHeader.TabIndex = 2;
            this.createTeamHeader.Text = "Create Team";
            // 
            // teamNameValue
            // 
            this.teamNameValue.FormattingEnabled = true;
            this.teamNameValue.Location = new System.Drawing.Point(32, 131);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(404, 38);
            this.teamNameValue.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.teamNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamNameLabel.Location = new System.Drawing.Point(23, 91);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(151, 37);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addMemberButton.Location = new System.Drawing.Point(92, 265);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(222, 51);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdownComboBox
            // 
            this.selectTeamMemberDropdownComboBox.FormattingEnabled = true;
            this.selectTeamMemberDropdownComboBox.Location = new System.Drawing.Point(30, 221);
            this.selectTeamMemberDropdownComboBox.Name = "selectTeamMemberDropdownComboBox";
            this.selectTeamMemberDropdownComboBox.Size = new System.Drawing.Size(404, 38);
            this.selectTeamMemberDropdownComboBox.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(23, 181);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(253, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.mobileNumberValue);
            this.addNewMemberGroupBox.Controls.Add(this.mobileNumberLable);
            this.addNewMemberGroupBox.Controls.Add(this.emailAddrssValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailAddressLable);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(32, 335);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(404, 345);
            this.addNewMemberGroupBox.TabIndex = 20;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(193, 47);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(200, 35);
            this.firstNameValue.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(138, 37);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(193, 100);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(200, 35);
            this.lastNameValue.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 98);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(135, 37);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailAddrssValue
            // 
            this.emailAddrssValue.Location = new System.Drawing.Point(193, 153);
            this.emailAddrssValue.Name = "emailAddrssValue";
            this.emailAddrssValue.Size = new System.Drawing.Size(200, 35);
            this.emailAddrssValue.TabIndex = 20;
            // 
            // emailAddressLable
            // 
            this.emailAddressLable.AutoSize = true;
            this.emailAddressLable.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.emailAddressLable.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.emailAddressLable.Location = new System.Drawing.Point(4, 151);
            this.emailAddressLable.Name = "emailAddressLable";
            this.emailAddressLable.Size = new System.Drawing.Size(174, 37);
            this.emailAddressLable.TabIndex = 19;
            this.emailAddressLable.Text = "Email Address";
            // 
            // mobileNumberValue
            // 
            this.mobileNumberValue.Location = new System.Drawing.Point(193, 208);
            this.mobileNumberValue.Name = "mobileNumberValue";
            this.mobileNumberValue.Size = new System.Drawing.Size(200, 35);
            this.mobileNumberValue.TabIndex = 22;
            // 
            // mobileNumberLable
            // 
            this.mobileNumberLable.AutoSize = true;
            this.mobileNumberLable.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.mobileNumberLable.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.mobileNumberLable.Location = new System.Drawing.Point(6, 206);
            this.mobileNumberLable.Name = "mobileNumberLable";
            this.mobileNumberLable.Size = new System.Drawing.Size(195, 37);
            this.mobileNumberLable.TabIndex = 21;
            this.mobileNumberLable.Text = "Mobile Number";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createMemberButton.Location = new System.Drawing.Point(101, 265);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(210, 51);
            this.createMemberButton.TabIndex = 23;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(442, 131);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(319, 544);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(767, 337);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(143, 80);
            this.deleteSelectedMemberButton.TabIndex = 23;
            this.deleteSelectedMemberButton.Text = "Delete Selectd";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTeamButton.Location = new System.Drawing.Point(389, 704);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(249, 51);
            this.createTeamButton.TabIndex = 24;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 781);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdownComboBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamHeader;
        private System.Windows.Forms.ComboBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdownComboBox;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox mobileNumberValue;
        private System.Windows.Forms.Label mobileNumberLable;
        private System.Windows.Forms.TextBox emailAddrssValue;
        private System.Windows.Forms.Label emailAddressLable;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}