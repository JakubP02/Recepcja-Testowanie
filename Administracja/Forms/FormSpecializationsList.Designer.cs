namespace Administracja.Forms
{
    partial class FormSpecializationsList
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
            buttonDeleteSpecialization = new Button();
            buttonEditSpecialization = new Button();
            buttonAddSpecialization = new Button();
            dataGridViewSpecializations = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDeleteSpecialization);
            groupBox1.Controls.Add(buttonEditSpecialization);
            groupBox1.Controls.Add(buttonAddSpecialization);
            groupBox1.Controls.Add(dataGridViewSpecializations);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 447);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Specializations";
            // 
            // buttonDeleteSpecialization
            // 
            buttonDeleteSpecialization.Location = new Point(546, 134);
            buttonDeleteSpecialization.Name = "buttonDeleteSpecialization";
            buttonDeleteSpecialization.Size = new Size(219, 45);
            buttonDeleteSpecialization.TabIndex = 3;
            buttonDeleteSpecialization.Text = "Delete specialization\r\n(select from the list above)";
            buttonDeleteSpecialization.UseVisualStyleBackColor = true;
            buttonDeleteSpecialization.Click += buttonDeleteSpecialization_Click;
            // 
            // buttonEditSpecialization
            // 
            buttonEditSpecialization.Location = new Point(546, 83);
            buttonEditSpecialization.Name = "buttonEditSpecialization";
            buttonEditSpecialization.Size = new Size(219, 45);
            buttonEditSpecialization.TabIndex = 3;
            buttonEditSpecialization.Text = "Edit Specialization\r\n(select from the list above)";
            buttonEditSpecialization.UseVisualStyleBackColor = true;
            buttonEditSpecialization.Click += buttonEditSpecialization_Click;
            // 
            // buttonAddSpecialization
            // 
            buttonAddSpecialization.Location = new Point(546, 32);
            buttonAddSpecialization.Name = "buttonAddSpecialization";
            buttonAddSpecialization.Size = new Size(219, 45);
            buttonAddSpecialization.TabIndex = 2;
            buttonAddSpecialization.Text = "Add new specialization";
            buttonAddSpecialization.UseVisualStyleBackColor = true;
            buttonAddSpecialization.Click += buttonAddSpecialization_Click;
            // 
            // dataGridViewSpecializations
            // 
            dataGridViewSpecializations.AllowUserToAddRows = false;
            dataGridViewSpecializations.AllowUserToDeleteRows = false;
            dataGridViewSpecializations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpecializations.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewSpecializations.Location = new Point(17, 32);
            dataGridViewSpecializations.MultiSelect = false;
            dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            dataGridViewSpecializations.ReadOnly = true;
            dataGridViewSpecializations.RowHeadersVisible = false;
            dataGridViewSpecializations.RowHeadersWidth = 51;
            dataGridViewSpecializations.RowTemplate.Height = 25;
            dataGridViewSpecializations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSpecializations.Size = new Size(278, 229);
            dataGridViewSpecializations.TabIndex = 1;
            dataGridViewSpecializations.CellContentClick += dataGridViewSpecializations_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nr.";
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
            // FormSpecializationsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSpecializationsList";
            Text = "FormSpecializationsList";
            Load += FormSpecializationsList_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDeleteSpecialization;
        private Button buttonEditSpecialization;
        private Button buttonAddSpecialization;
        private DataGridView dataGridViewSpecializations;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}