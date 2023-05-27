namespace Recepcja.Forms
{
    partial class addDoctorprompt
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
            btnCancel = new Button();
            dataGridViewLastDoctor = new DataGridView();
            btnOtherDoctors = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLastDoctor).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(152, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 23);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridViewLastDoctor
            // 
            dataGridViewLastDoctor.AllowUserToAddRows = false;
            dataGridViewLastDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLastDoctor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewLastDoctor.Location = new Point(152, 65);
            dataGridViewLastDoctor.MultiSelect = false;
            dataGridViewLastDoctor.Name = "dataGridViewLastDoctor";
            dataGridViewLastDoctor.RowHeadersVisible = false;
            dataGridViewLastDoctor.RowHeadersWidth = 51;
            dataGridViewLastDoctor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewLastDoctor.RowTemplate.Height = 25;
            dataGridViewLastDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLastDoctor.Size = new Size(102, 266);
            dataGridViewLastDoctor.TabIndex = 49;
            dataGridViewLastDoctor.VirtualMode = true;
            dataGridViewLastDoctor.CellClick += dataGridViewLastDoctor_CellClick;
            dataGridViewLastDoctor.SelectionChanged += dataGridViewLastDoctor_SelectionChanged;
            dataGridViewLastDoctor.Click += dataGridViewLastDoctor_Click;
            // 
            // btnOtherDoctors
            // 
            btnOtherDoctors.Location = new Point(152, 337);
            btnOtherDoctors.Name = "btnOtherDoctors";
            btnOtherDoctors.Size = new Size(102, 23);
            btnOtherDoctors.TabIndex = 50;
            btnOtherDoctors.Text = "OtherDoctors";
            btnOtherDoctors.UseVisualStyleBackColor = true;
            btnOtherDoctors.Click += btnOtherDoctors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 51;
            label1.Text = "lastDoctor";
            // 
            // addDoctorprompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 413);
            Controls.Add(label1);
            Controls.Add(btnOtherDoctors);
            Controls.Add(dataGridViewLastDoctor);
            Controls.Add(btnCancel);
            Name = "addDoctorprompt";
            Text = "addDoctorprompt";
            Load += addDoctorprompt_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLastDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private DataGridView dataGridViewLastDoctor;
        private Button btnOtherDoctors;
        private Label label1;
    }
}