namespace Administracja.Forms
{
    partial class FormRolesList
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
            buttonDeleteRole = new Button();
            buttonEditRole = new Button();
            buttonAddRole = new Button();
            dataGridViewRoles = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDeleteRole);
            groupBox1.Controls.Add(buttonEditRole);
            groupBox1.Controls.Add(buttonAddRole);
            groupBox1.Controls.Add(dataGridViewRoles);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 596);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Roles";
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(624, 179);
            buttonDeleteRole.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(250, 60);
            buttonDeleteRole.TabIndex = 3;
            buttonDeleteRole.Text = "Delete role\r\n(select from the list above)";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            buttonDeleteRole.Click += buttonDeleteRole_Click;
            // 
            // buttonEditRole
            // 
            buttonEditRole.Location = new Point(624, 111);
            buttonEditRole.Margin = new Padding(3, 4, 3, 4);
            buttonEditRole.Name = "buttonEditRole";
            buttonEditRole.Size = new Size(250, 60);
            buttonEditRole.TabIndex = 3;
            buttonEditRole.Text = "Edit role\r\n(select from the list above)";
            buttonEditRole.UseVisualStyleBackColor = true;
            buttonEditRole.Click += buttonEditRole_Click;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(624, 43);
            buttonAddRole.Margin = new Padding(3, 4, 3, 4);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(250, 60);
            buttonAddRole.TabIndex = 2;
            buttonAddRole.Text = "Add new role";
            buttonAddRole.UseVisualStyleBackColor = true;
            buttonAddRole.Click += buttonAddRole_Click;
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.AllowUserToAddRows = false;
            dataGridViewRoles.AllowUserToDeleteRows = false;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewRoles.Location = new Point(19, 43);
            dataGridViewRoles.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRoles.MultiSelect = false;
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.RowHeadersWidth = 51;
            dataGridViewRoles.RowTemplate.Height = 25;
            dataGridViewRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoles.Size = new Size(326, 305);
            dataGridViewRoles.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // FormRolesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRolesList";
            Text = "FormRolesList";
            Load += FormRolesList_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDeleteRole;
        private Button buttonEditRole;
        private Button buttonAddRole;
        private DataGridView dataGridViewRoles;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}