namespace Administracja.Forms
{
    partial class FormUsersList
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
            groupBox1 = new GroupBox();
            buttonFilter = new Button();
            buttonClear = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            comboBoxRole = new ComboBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            buttonChangeStatus = new Button();
            buttonEditUser = new Button();
            dataGridViewUsers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            namecolumn = new DataGridViewTextBoxColumn();
            lastnamecolumn = new DataGridViewTextBoxColumn();
            rolecolumn = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            expDate = new DataGridViewTextBoxColumn();
            buttonDetails = new Button();
            btnAddUser = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(buttonChangeStatus);
            groupBox1.Controls.Add(buttonEditUser);
            groupBox1.Controls.Add(dataGridViewUsers);
            groupBox1.Controls.Add(buttonDetails);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 446);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users";
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(213, 342);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(120, 28);
            buttonFilter.TabIndex = 19;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(66, 342);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 28);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 264);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 17;
            label4.Text = "Employee Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 264);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 16;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 199);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 15;
            label2.Text = "Employee Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 199);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 14;
            label1.Text = "Employee Name:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(65, 286);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(121, 23);
            textBoxUsername.TabIndex = 13;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(213, 286);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(213, 222);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(121, 23);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(65, 222);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 9;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.Location = new Point(545, 366);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(219, 45);
            buttonChangeStatus.TabIndex = 8;
            buttonChangeStatus.Text = "Change user status";
            buttonChangeStatus.UseVisualStyleBackColor = true;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(545, 315);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(219, 45);
            buttonEditUser.TabIndex = 7;
            buttonEditUser.Text = "Edit user data";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, username, namecolumn, lastnamecolumn, rolecolumn, ColumnRole, expDate });
            dataGridViewUsers.Location = new Point(6, 22);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(758, 160);
            dataGridViewUsers.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nr.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // username
            // 
            username.HeaderText = "username";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // namecolumn
            // 
            namecolumn.HeaderText = "Employee Name";
            namecolumn.MinimumWidth = 6;
            namecolumn.Name = "namecolumn";
            namecolumn.ReadOnly = true;
            namecolumn.Width = 125;
            // 
            // lastnamecolumn
            // 
            lastnamecolumn.HeaderText = "Employee Lastname";
            lastnamecolumn.MinimumWidth = 6;
            lastnamecolumn.Name = "lastnamecolumn";
            lastnamecolumn.ReadOnly = true;
            lastnamecolumn.Width = 125;
            // 
            // rolecolumn
            // 
            rolecolumn.HeaderText = "Role";
            rolecolumn.MinimumWidth = 6;
            rolecolumn.Name = "rolecolumn";
            rolecolumn.ReadOnly = true;
            rolecolumn.Width = 125;
            // 
            // ColumnRole
            // 
            ColumnRole.HeaderText = "Status";
            ColumnRole.MinimumWidth = 6;
            ColumnRole.Name = "ColumnRole";
            ColumnRole.ReadOnly = true;
            ColumnRole.Width = 125;
            // 
            // expDate
            // 
            expDate.HeaderText = "Expiration date";
            expDate.Name = "expDate";
            expDate.ReadOnly = true;
            expDate.Width = 105;
            // 
            // buttonDetails
            // 
            buttonDetails.Location = new Point(545, 264);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(219, 45);
            buttonDetails.TabIndex = 3;
            buttonDetails.Text = "Details";
            buttonDetails.UseVisualStyleBackColor = true;
            buttonDetails.Click += buttonDetails_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(545, 213);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(219, 45);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add a User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // FormUsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsersList";
            Text = "FormUsersList";
            Load += FormUsersList_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnAddUser;
        private Button buttonDetails;
        private DataGridView dataGridViewUsers;
        private Button buttonEditUser;
        private Button buttonChangeStatus;
        private ComboBox comboBoxRole;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private TextBox textBoxUsername;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonFilter;
        private Button buttonClear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn namecolumn;
        private DataGridViewTextBoxColumn lastnamecolumn;
        private DataGridViewTextBoxColumn rolecolumn;
        private DataGridViewTextBoxColumn ColumnRole;
        private DataGridViewTextBoxColumn expDate;
    }
}