namespace Administracja.Forms
{
    partial class FormOfficeList
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
            buttonDelete = new Button();
            buttonDeactivateOffice = new Button();
            buttonEditOffice = new Button();
            buttonAddOffice = new Button();
            dataGridViewOffice = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            namecolumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonDeactivateOffice);
            groupBox1.Controls.Add(buttonEditOffice);
            groupBox1.Controls.Add(buttonAddOffice);
            groupBox1.Controls.Add(dataGridViewOffice);
            groupBox1.Location = new Point(15, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 446);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Offices";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(503, 372);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(219, 45);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Delete office";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDeactivateOffice
            // 
            buttonDeactivateOffice.Location = new Point(503, 270);
            buttonDeactivateOffice.Name = "buttonDeactivateOffice";
            buttonDeactivateOffice.Size = new Size(219, 45);
            buttonDeactivateOffice.TabIndex = 3;
            buttonDeactivateOffice.Text = "Change office status\r\n(select from the list above)";
            buttonDeactivateOffice.UseVisualStyleBackColor = true;
            buttonDeactivateOffice.Click += buttonDeactivateOffice_Click;
            // 
            // buttonEditOffice
            // 
            buttonEditOffice.Location = new Point(503, 321);
            buttonEditOffice.Name = "buttonEditOffice";
            buttonEditOffice.Size = new Size(219, 45);
            buttonEditOffice.TabIndex = 20;
            buttonEditOffice.Text = "Change office data\r\n(select from the list above)";
            buttonEditOffice.UseVisualStyleBackColor = true;
            buttonEditOffice.Click += buttonEditEmployee_Click;
            // 
            // buttonAddOffice
            // 
            buttonAddOffice.Location = new Point(503, 219);
            buttonAddOffice.Name = "buttonAddOffice";
            buttonAddOffice.Size = new Size(219, 45);
            buttonAddOffice.TabIndex = 2;
            buttonAddOffice.Text = "Add new office";
            buttonAddOffice.UseVisualStyleBackColor = true;
            buttonAddOffice.Click += buttonAddOffice_Click;
            // 
            // dataGridViewOffice
            // 
            dataGridViewOffice.AllowUserToAddRows = false;
            dataGridViewOffice.AllowUserToDeleteRows = false;
            dataGridViewOffice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOffice.Columns.AddRange(new DataGridViewColumn[] { Column1, namecolumn, Column3, ColumnStatus, ColumnRole });
            dataGridViewOffice.Location = new Point(72, 22);
            dataGridViewOffice.MultiSelect = false;
            dataGridViewOffice.Name = "dataGridViewOffice";
            dataGridViewOffice.ReadOnly = true;
            dataGridViewOffice.RowHeadersVisible = false;
            dataGridViewOffice.RowHeadersWidth = 51;
            dataGridViewOffice.RowTemplate.Height = 25;
            dataGridViewOffice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOffice.Size = new Size(628, 179);
            dataGridViewOffice.TabIndex = 1;
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
            namecolumn.HeaderText = "Number";
            namecolumn.MinimumWidth = 6;
            namecolumn.Name = "namecolumn";
            namecolumn.ReadOnly = true;
            namecolumn.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Id Specialization";
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
            ColumnRole.HeaderText = "Is general meeting";
            ColumnRole.MinimumWidth = 6;
            ColumnRole.Name = "ColumnRole";
            ColumnRole.ReadOnly = true;
            ColumnRole.Width = 125;
            // 
            // FormOfficeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormOfficeList";
            Text = "FormOfficeList";
            Load += FormOfficeList_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDeactivateOffice;
        private Button buttonEditOffice;
        private Button buttonAddOffice;
        private DataGridView dataGridViewOffice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn namecolumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnRole;
        private Button buttonDelete;
    }
}