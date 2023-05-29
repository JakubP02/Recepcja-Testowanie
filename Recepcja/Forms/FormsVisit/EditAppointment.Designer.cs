namespace Recepcja
{
    partial class EditAppointment
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
            btnSearchVisit = new Button();
            label6 = new Label();
            txtPesel = new TextBox();
            dataGridView_lista_wizyt = new DataGridView();
            btnEditVisit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).BeginInit();
            SuspendLayout();
            // 
            // btnSearchVisit
            // 
            btnSearchVisit.Location = new Point(651, 214);
            btnSearchVisit.Name = "btnSearchVisit";
            btnSearchVisit.Size = new Size(159, 23);
            btnSearchVisit.TabIndex = 33;
            btnSearchVisit.Text = "Search";
            btnSearchVisit.UseVisualStyleBackColor = true;
            btnSearchVisit.Click += btnSearchVisit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(651, 167);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 32;
            label6.Text = "PESEL";
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(651, 185);
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(160, 23);
            txtPesel.TabIndex = 31;
            // 
            // dataGridView_lista_wizyt
            // 
            dataGridView_lista_wizyt.AllowUserToAddRows = false;
            dataGridView_lista_wizyt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista_wizyt.Location = new Point(12, 21);
            dataGridView_lista_wizyt.Name = "dataGridView_lista_wizyt";
            dataGridView_lista_wizyt.ReadOnly = true;
            dataGridView_lista_wizyt.RowHeadersVisible = false;
            dataGridView_lista_wizyt.RowHeadersWidth = 51;
            dataGridView_lista_wizyt.RowTemplate.Height = 25;
            dataGridView_lista_wizyt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_lista_wizyt.Size = new Size(608, 645);
            dataGridView_lista_wizyt.TabIndex = 30;
            // 
            // btnEditVisit
            // 
            btnEditVisit.Location = new Point(12, 684);
            btnEditVisit.Name = "btnEditVisit";
            btnEditVisit.Size = new Size(608, 42);
            btnEditVisit.TabIndex = 34;
            btnEditVisit.Text = "Edit";
            btnEditVisit.UseVisualStyleBackColor = true;
            btnEditVisit.Click += btnEditVisit_Click;
            // 
            // EditAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 766);
            Controls.Add(btnEditVisit);
            Controls.Add(btnSearchVisit);
            Controls.Add(label6);
            Controls.Add(txtPesel);
            Controls.Add(dataGridView_lista_wizyt);
            Name = "EditAppointment";
            Text = "Edit appoitment";
            Load += EditAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchVisit;
        private Label label6;
        private TextBox txtPesel;
        private Button btnEditVisit;
        internal DataGridView dataGridView_lista_wizyt;
    }
}