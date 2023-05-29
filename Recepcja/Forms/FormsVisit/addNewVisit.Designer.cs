namespace Recepcja
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
            button_add_visit = new Button();
            dataGridView_patients = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // button_add_visit
            // 
            button_add_visit.Location = new Point(24, 615);
            button_add_visit.Name = "button_add_visit";
            button_add_visit.Size = new Size(494, 39);
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
            dataGridView_patients.Location = new Point(24, 12);
            dataGridView_patients.MultiSelect = false;
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidth = 51;
            dataGridView_patients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(494, 597);
            dataGridView_patients.TabIndex = 21;
            dataGridView_patients.VirtualMode = true;
            // 
            // button1
            // 
            button1.Location = new Point(24, 660);
            button1.Name = "button1";
            button1.Size = new Size(494, 39);
            button1.TabIndex = 22;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addNewVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 717);
            Controls.Add(button1);
            Controls.Add(dataGridView_patients);
            Controls.Add(button_add_visit);
            Name = "addNewVisit";
            Text = "Add new visit";
            Load += addNewVisit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_add_visit;
        private DataGridView dataGridView_patients;
        private Button button1;
    }
}