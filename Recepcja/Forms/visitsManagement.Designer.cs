namespace Patient_handling
{
    partial class ZarzadzanieWizytami
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
            dataGridView_lista_wizyt = new DataGridView();
            button_cancel_visit = new Button();
            button_Send_confirmation = new Button();
            button_Clear_the_calendar = new Button();
            button1 = new Button();
            label6 = new Label();
            txtPesel = new TextBox();
            btnSearchVisit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_lista_wizyt
            // 
            dataGridView_lista_wizyt.AllowUserToAddRows = false;
            dataGridView_lista_wizyt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista_wizyt.Location = new Point(29, 65);
            dataGridView_lista_wizyt.Name = "dataGridView_lista_wizyt";
            dataGridView_lista_wizyt.ReadOnly = true;
            dataGridView_lista_wizyt.RowHeadersVisible = false;
            dataGridView_lista_wizyt.RowHeadersWidth = 51;
            dataGridView_lista_wizyt.RowTemplate.Height = 25;
            dataGridView_lista_wizyt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_lista_wizyt.Size = new Size(608, 645);
            dataGridView_lista_wizyt.TabIndex = 0;
            dataGridView_lista_wizyt.CellContentClick += dataGridView_lista_wizyt_CellContentClick;
            // 
            // button_cancel_visit
            // 
            button_cancel_visit.Location = new Point(27, 716);
            button_cancel_visit.Name = "button_cancel_visit";
            button_cancel_visit.Size = new Size(85, 26);
            button_cancel_visit.TabIndex = 4;
            button_cancel_visit.Text = "Cancel visit";
            button_cancel_visit.UseVisualStyleBackColor = true;
            button_cancel_visit.Click += button_cancel_visit_Click;
            // 
            // button_Send_confirmation
            // 
            button_Send_confirmation.Location = new Point(263, 716);
            button_Send_confirmation.Name = "button_Send_confirmation";
            button_Send_confirmation.Size = new Size(125, 26);
            button_Send_confirmation.TabIndex = 5;
            button_Send_confirmation.Text = "Send confirmation";
            button_Send_confirmation.UseVisualStyleBackColor = true;
            button_Send_confirmation.Click += button_Send_confirmation_Click;
            // 
            // button_Clear_the_calendar
            // 
            button_Clear_the_calendar.Location = new Point(29, 36);
            button_Clear_the_calendar.Name = "button_Clear_the_calendar";
            button_Clear_the_calendar.Size = new Size(129, 26);
            button_Clear_the_calendar.TabIndex = 6;
            button_Clear_the_calendar.Text = "Clear the calendar";
            button_Clear_the_calendar.UseVisualStyleBackColor = true;
            button_Clear_the_calendar.Click += button_Clear_the_calendar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(519, 716);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 7;
            button1.Text = "Visit details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 158);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 28;
            label6.Text = "PESEL";
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(679, 176);
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(160, 23);
            txtPesel.TabIndex = 27;
            // 
            // btnSearchVisit
            // 
            btnSearchVisit.Location = new Point(679, 205);
            btnSearchVisit.Name = "btnSearchVisit";
            btnSearchVisit.Size = new Size(159, 23);
            btnSearchVisit.TabIndex = 29;
            btnSearchVisit.Text = "Search";
            btnSearchVisit.UseVisualStyleBackColor = true;
            btnSearchVisit.Click += btnSearchVisit_Click;
            // 
            // ZarzadzanieWizytami
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 791);
            Controls.Add(btnSearchVisit);
            Controls.Add(label6);
            Controls.Add(txtPesel);
            Controls.Add(button1);
            Controls.Add(button_Clear_the_calendar);
            Controls.Add(button_Send_confirmation);
            Controls.Add(button_cancel_visit);
            Controls.Add(dataGridView_lista_wizyt);
            Name = "ZarzadzanieWizytami";
            Text = "ZarządzanieWizytami";
            Load += ZarządzanieWizytami_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_lista_wizyt;
        private Button button_cancel_visit;
        private Button button_Send_confirmation;
        private Button button_Clear_the_calendar;
        private Button button1;
        private Label label6;
        private TextBox txtPesel;
        private Button btnSearchVisit;
    }
}