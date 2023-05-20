namespace Patient_handling
{
    partial class addNewVisit
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
            comboBox_patinet_add = new ComboBox();
            label1 = new Label();
            button_add_visit = new Button();
            dataGridView_patients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // comboBox_patinet_add
            // 
            comboBox_patinet_add.FormattingEnabled = true;
            comboBox_patinet_add.Location = new Point(48, 129);
            comboBox_patinet_add.Margin = new Padding(3, 4, 3, 4);
            comboBox_patinet_add.Name = "comboBox_patinet_add";
            comboBox_patinet_add.Size = new Size(148, 28);
            comboBox_patinet_add.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 108);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Patient";
            // 
            // button_add_visit
            // 
            button_add_visit.Location = new Point(47, 168);
            button_add_visit.Margin = new Padding(3, 4, 3, 4);
            button_add_visit.Name = "button_add_visit";
            button_add_visit.Size = new Size(150, 31);
            button_add_visit.TabIndex = 8;
            button_add_visit.Text = "Add ";
            button_add_visit.UseVisualStyleBackColor = true;
            button_add_visit.Click += button_add_visit_Click;
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.AllowUserToAddRows = false;
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(214, 4);
            dataGridView_patients.Margin = new Padding(3, 4, 3, 4);
            dataGridView_patients.MultiSelect = false;
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidth = 51;
            dataGridView_patients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(663, 208);
            dataGridView_patients.TabIndex = 21;
            dataGridView_patients.VirtualMode = true;
            // 
            // addNewVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 307);
            Controls.Add(dataGridView_patients);
            Controls.Add(button_add_visit);
            Controls.Add(label1);
            Controls.Add(comboBox_patinet_add);
            Margin = new Padding(3, 4, 3, 4);
            Name = "addNewVisit";
            Text = "Add new visit";
            Load += addNewVisit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_patinet_add;
        private Label label1;
        private Button button_add_visit;
        private DataGridView dataGridView_patients;
    }
}