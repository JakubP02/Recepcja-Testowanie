namespace Administracja.FormsCalendar
{
    partial class FormCalendarSessionList
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
            buttonBack = new Button();
            dataGridViewSessions = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSessions).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(134, 517);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(250, 60);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewSessions
            // 
            dataGridViewSessions.AllowUserToAddRows = false;
            dataGridViewSessions.AllowUserToDeleteRows = false;
            dataGridViewSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSessions.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column6, Column4, Column5 });
            dataGridViewSessions.Location = new Point(67, 29);
            dataGridViewSessions.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSessions.Name = "dataGridViewSessions";
            dataGridViewSessions.RowHeadersVisible = false;
            dataGridViewSessions.RowHeadersWidth = 51;
            dataGridViewSessions.RowTemplate.Height = 25;
            dataGridViewSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSessions.Size = new Size(717, 403);
            dataGridViewSessions.TabIndex = 2;
            // 
            // Column2
            // 
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "Employee";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Office";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Working from";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Working To";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(504, 517);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(250, 60);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // FormCalendarSessionList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 600);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridViewSessions);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCalendarSessionList";
            Text = "FormCalendarSessionList";
            Load += FormCalendarSessionList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSessions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private DataGridView dataGridViewSessions;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button buttonEdit;
    }
}