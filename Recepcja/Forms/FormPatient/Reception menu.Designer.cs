namespace Recepcja
{
    partial class Form_reception_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(294, 319);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(153, 23);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            button_menu_activate_patient.Click += button_menu_activate_patient_Click;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(472, 319);
            button_menu_remove_patient.Name = "button_menu_remove_patient";
            button_menu_remove_patient.Size = new Size(153, 23);
            button_menu_remove_patient.TabIndex = 4;
            button_menu_remove_patient.Text = "Deactivate patient";
            button_menu_remove_patient.UseVisualStyleBackColor = true;
            button_menu_remove_patient.Click += button_menu_remove_patient_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1007, 273);
            dataGridView1.TabIndex = 5;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 354);
            Controls.Add(dataGridView1);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            Load += Form_reception_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private DataGridView dataGridView1;
    }
}