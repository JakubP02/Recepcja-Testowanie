namespace Administracja.FormsDoctor
{
    partial class FormDoctorCalendars
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewDoctorCalendars = new DataGridView();
            Calendar = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            btnAccept = new Button();
            btnChange = new Button();
            labelDate = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            daycontainer = new FlowLayoutPanel();
            btnViewCalendar = new Button();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorCalendars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDoctorCalendars
            // 
            dataGridViewDoctorCalendars.AllowUserToAddRows = false;
            dataGridViewDoctorCalendars.AllowUserToDeleteRows = false;
            dataGridViewDoctorCalendars.AllowUserToResizeColumns = false;
            dataGridViewDoctorCalendars.AllowUserToResizeRows = false;
            dataGridViewDoctorCalendars.BackgroundColor = Color.Silver;
            dataGridViewDoctorCalendars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDoctorCalendars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDoctorCalendars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctorCalendars.Columns.AddRange(new DataGridViewColumn[] { Calendar, ColumnStatus });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewDoctorCalendars.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDoctorCalendars.Location = new Point(12, 9);
            dataGridViewDoctorCalendars.MultiSelect = false;
            dataGridViewDoctorCalendars.Name = "dataGridViewDoctorCalendars";
            dataGridViewDoctorCalendars.ReadOnly = true;
            dataGridViewDoctorCalendars.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewDoctorCalendars.RowHeadersVisible = false;
            dataGridViewDoctorCalendars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDoctorCalendars.RowTemplate.Height = 25;
            dataGridViewDoctorCalendars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoctorCalendars.Size = new Size(203, 362);
            dataGridViewDoctorCalendars.TabIndex = 0;
            // 
            // Calendar
            // 
            Calendar.HeaderText = "Calendars";
            Calendar.Name = "Calendar";
            Calendar.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(208, 247, 193);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccept.Location = new Point(12, 415);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(106, 46);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click_1;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(250, 201, 186);
            btnChange.FlatStyle = FlatStyle.Popup;
            btnChange.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.Location = new Point(118, 415);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(97, 46);
            btnChange.TabIndex = 2;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click_1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(647, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(42, 21);
            labelDate.TabIndex = 19;
            labelDate.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(281, 41);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 18;
            label7.Text = "Sunday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1039, 41);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 17;
            label6.Text = "Saturday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(910, 41);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 16;
            label5.Text = "Friday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(779, 41);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 15;
            label4.Text = "Thursday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(647, 41);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 14;
            label3.Text = "Wednesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 13;
            label2.Text = "Tuesday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(392, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Monday";
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(232, 64);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(906, 397);
            daycontainer.TabIndex = 11;
            // 
            // btnViewCalendar
            // 
            btnViewCalendar.BackColor = Color.Transparent;
            btnViewCalendar.FlatStyle = FlatStyle.Flat;
            btnViewCalendar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCalendar.ForeColor = SystemColors.ActiveCaptionText;
            btnViewCalendar.Location = new Point(12, 369);
            btnViewCalendar.Name = "btnViewCalendar";
            btnViewCalendar.Size = new Size(203, 46);
            btnViewCalendar.TabIndex = 20;
            btnViewCalendar.Text = "View calendar";
            btnViewCalendar.UseVisualStyleBackColor = false;
            btnViewCalendar.Click += btnViewCalendar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Location = new Point(392, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(35, 21);
            panel1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(433, 440);
            label8.Name = "label8";
            label8.Size = new Size(137, 17);
            label8.TabIndex = 22;
            label8.Text = "← work not scheduled";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Location = new Point(755, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(35, 21);
            panel2.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(796, 440);
            label9.Name = "label9";
            label9.Size = new Size(114, 17);
            label9.TabIndex = 24;
            label9.Text = "← work scheduled";
            // 
            // FormDoctorCalendars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 485);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnViewCalendar);
            Controls.Add(labelDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            Controls.Add(btnChange);
            Controls.Add(btnAccept);
            Controls.Add(dataGridViewDoctorCalendars);
            Name = "FormDoctorCalendars";
            Text = "FormDoctorCalendars";
            Load += FormDoctorCalendars_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorCalendars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDoctorCalendars;
        private DataGridViewTextBoxColumn Calendar;
        private DataGridViewTextBoxColumn ColumnStatus;
        private Button btnAccept;
        private Button btnChange;
        private Label labelDate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel daycontainer;
        private Button btnViewCalendar;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label9;
    }
}