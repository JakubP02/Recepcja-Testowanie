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
            dataGridView_lista_wizyt.Size = new Size(588, 150);
            dataGridView_lista_wizyt.TabIndex = 0;
            dataGridView_lista_wizyt.CellContentClick += dataGridView_lista_wizyt_CellContentClick;
            // 
            // button_cancel_visit
            // 
            button_cancel_visit.Location = new Point(29, 230);
            button_cancel_visit.Name = "button_cancel_visit";
            button_cancel_visit.Size = new Size(85, 26);
            button_cancel_visit.TabIndex = 4;
            button_cancel_visit.Text = "Cancel visit";
            button_cancel_visit.UseVisualStyleBackColor = true;
            button_cancel_visit.Click += button_cancel_visit_Click;
            // 
            // button_Send_confirmation
            // 
            button_Send_confirmation.Location = new Point(236, 230);
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
            button1.Location = new Point(499, 230);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 7;
            button1.Text = "Visit details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ZarzadzanieWizytami
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 315);
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
        }

        #endregion

        private DataGridView dataGridView_lista_wizyt;
        private Button button_cancel_visit;
        private Button button_Send_confirmation;
        private Button button_Clear_the_calendar;
        private Button button1;
    }
}