namespace Administracja.Forms
{
    partial class FormEmployeeList
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridViewEmployees = new DataGridView();
            groupBox1 = new GroupBox();
            buttonDeactivateEmployee = new Button();
            buttonFilter = new Button();
            buttonEditEmployee = new Button();
            buttonClear = new Button();
            buttonReviewTheEmployee = new Button();
            comboBoxRole = new ComboBox();
            buttonAddWorker = new Button();
            labelRole = new Label();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            namecolumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { Column1, namecolumn, Column3, ColumnStatus, ColumnRole });
            dataGridViewEmployees.Location = new Point(72, 22);
            dataGridViewEmployees.MultiSelect = false;
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(628, 179);
            dataGridViewEmployees.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDeactivateEmployee);
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(buttonEditEmployee);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonReviewTheEmployee);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(buttonAddWorker);
            groupBox1.Controls.Add(labelRole);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(dataGridViewEmployees);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 446);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pracownicy";
            // 
            // buttonDeactivateEmployee
            // 
            buttonDeactivateEmployee.Location = new Point(503, 270);
            buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            buttonDeactivateEmployee.Size = new Size(219, 45);
            buttonDeactivateEmployee.TabIndex = 3;
            buttonDeactivateEmployee.Text = "Change employee status\r\n(select from the list above)";
            buttonDeactivateEmployee.UseVisualStyleBackColor = true;
            buttonDeactivateEmployee.Click += buttonDeactivateEmployee_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(257, 336);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(156, 27);
            buttonFilter.TabIndex = 19;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonEditEmployee
            // 
            buttonEditEmployee.Location = new Point(503, 372);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(219, 45);
            buttonEditEmployee.TabIndex = 20;
            buttonEditEmployee.Text = "Change employee data\r\n(select from the list above)";
            buttonEditEmployee.UseVisualStyleBackColor = true;
            buttonEditEmployee.Click += buttonEditEmployee_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(45, 336);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(164, 27);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonReviewTheEmployee
            // 
            buttonReviewTheEmployee.Location = new Point(503, 321);
            buttonReviewTheEmployee.Name = "buttonReviewTheEmployee";
            buttonReviewTheEmployee.Size = new Size(219, 45);
            buttonReviewTheEmployee.TabIndex = 3;
            buttonReviewTheEmployee.Text = "Review the employee \r\n(select from the list above)";
            buttonReviewTheEmployee.UseVisualStyleBackColor = true;
            buttonReviewTheEmployee.Click += buttonReviewTheEmployee_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(126, 289);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(220, 23);
            comboBoxRole.TabIndex = 17;
            // 
            // buttonAddWorker
            // 
            buttonAddWorker.Location = new Point(503, 219);
            buttonAddWorker.Name = "buttonAddWorker";
            buttonAddWorker.Size = new Size(219, 45);
            buttonAddWorker.TabIndex = 2;
            buttonAddWorker.Text = "Add new employee";
            buttonAddWorker.UseVisualStyleBackColor = true;
            buttonAddWorker.Click += buttonAddWorker_Click;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(126, 271);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(33, 15);
            labelRole.TabIndex = 16;
            labelRole.Text = "Role:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(127, 238);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(219, 23);
            comboBoxStatus.TabIndex = 15;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(127, 220);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "Status:";
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // namecolumn
            // 
            namecolumn.HeaderText = "Name";
            namecolumn.MinimumWidth = 6;
            namecolumn.Name = "namecolumn";
            namecolumn.ReadOnly = true;
            namecolumn.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Last name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.Width = 125;
            // 
            // ColumnRole
            // 
            ColumnRole.HeaderText = "Role";
            ColumnRole.MinimumWidth = 6;
            ColumnRole.Name = "ColumnRole";
            ColumnRole.ReadOnly = true;
            ColumnRole.Width = 125;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployeeList";
            Text = "Form2";
            Load += FormEmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridViewEmployees;
        private GroupBox groupBox1;
        private Button buttonAddWorker;
        private Button buttonDeactivateEmployee;
        private Button buttonReviewTheEmployee;
        private Button buttonFilter;
        private Button buttonClear;
        private ComboBox comboBoxRole;
        private Label labelRole;
        private ComboBox comboBoxStatus;
        private Label labelStatus;
        private Button buttonEditEmployee;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn namecolumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnRole;
    }
}