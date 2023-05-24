namespace Recepcja.Forms
{
    partial class FormSelectPatientToVisit
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
            dataGridView_patients = new DataGridView();
            label6 = new Label();
            txtPesel = new TextBox();
            button_filter_patient_form_data = new Button();
            label_date = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.AllowUserToAddRows = false;
            dataGridView_patients.AllowUserToResizeColumns = false;
            dataGridView_patients.AllowUserToResizeRows = false;
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(192, 64);
            dataGridView_patients.MultiSelect = false;
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(906, 364);
            dataGridView_patients.TabIndex = 48;
            dataGridView_patients.VirtualMode = true;
            dataGridView_patients.CellClick += dataGridView_patients_CellClick;
            dataGridView_patients.CellContentClick += dataGridView_patients_CellContentClick;
            dataGridView_patients.SelectionChanged += dataGridView_patients_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 177);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 45;
            label6.Text = "PESEL";
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(15, 195);
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(160, 23);
            txtPesel.TabIndex = 40;
            // 
            // button_filter_patient_form_data
            // 
            button_filter_patient_form_data.Location = new Point(15, 224);
            button_filter_patient_form_data.Name = "button_filter_patient_form_data";
            button_filter_patient_form_data.Size = new Size(160, 23);
            button_filter_patient_form_data.TabIndex = 35;
            button_filter_patient_form_data.Text = "Search";
            button_filter_patient_form_data.UseVisualStyleBackColor = true;
            button_filter_patient_form_data.Click += button_filter_patient_form_data_Click;
            // 
            // label_date
            // 
            label_date.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(429, 22);
            label_date.Name = "label_date";
            label_date.Size = new Size(437, 30);
            label_date.TabIndex = 50;
            label_date.Text = "Select a Patient";
            label_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSelectPatientToVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 456);
            Controls.Add(label_date);
            Controls.Add(dataGridView_patients);
            Controls.Add(label6);
            Controls.Add(txtPesel);
            Controls.Add(button_filter_patient_form_data);
            Name = "FormSelectPatientToVisit";
            Text = "FormSelectPatientToVisit";
            Load += FormSelectPatientToVisit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_patients;
        private Label label6;
        private TextBox txtPesel;
        private Button button_filter_patient_form_data;
        private Label label_date;
    }
}