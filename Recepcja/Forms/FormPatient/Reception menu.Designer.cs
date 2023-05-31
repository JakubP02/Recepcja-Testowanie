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
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(274, 319);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(153, 23);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            button_menu_activate_patient.Click += button_menu_activate_patient_Click;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(452, 319);
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
            dataGridView1.Location = new Point(18, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(904, 273);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(button_menu_activate_patient);
            groupBox4.Controls.Add(button_menu_remove_patient);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(949, 370);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Menu";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 699);
            Controls.Add(groupBox4);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            Load += Form_reception_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
    }
}