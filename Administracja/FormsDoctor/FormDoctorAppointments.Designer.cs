namespace Administracja.FormsDoctor
{
    partial class FormDoctorAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDoctorAppointments = new System.Windows.Forms.DataGridView();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxOffice = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.panelAppointmentDetails = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelChoosePatient = new System.Windows.Forms.Label();
            this.comboBoxChoosePatient = new System.Windows.Forms.ComboBox();
            this.panelAppointmentCalendar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnViewCalendar = new System.Windows.Forms.Button();
            this.dataGridViewDoctorCalendars = new System.Windows.Forms.DataGridView();
            this.ColumnCalendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDate = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorAppointments)).BeginInit();
            this.panelAppointmentDetails.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panelAppointmentCalendar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorCalendars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorAppointments
            // 
            this.dataGridViewDoctorAppointments.AllowUserToAddRows = false;
            this.dataGridViewDoctorAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewDoctorAppointments.AllowUserToResizeColumns = false;
            this.dataGridViewDoctorAppointments.AllowUserToResizeRows = false;
            this.dataGridViewDoctorAppointments.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewDoctorAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDoctorAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDoctorAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTime,
            this.ColumnOffice,
            this.ColumnPatient});
            this.dataGridViewDoctorAppointments.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewDoctorAppointments.MultiSelect = false;
            this.dataGridViewDoctorAppointments.Name = "dataGridViewDoctorAppointments";
            this.dataGridViewDoctorAppointments.ReadOnly = true;
            this.dataGridViewDoctorAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDoctorAppointments.RowHeadersVisible = false;
            this.dataGridViewDoctorAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDoctorAppointments.RowTemplate.Height = 25;
            this.dataGridViewDoctorAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewDoctorAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctorAppointments.Size = new System.Drawing.Size(360, 426);
            this.dataGridViewDoctorAppointments.TabIndex = 1;
            this.dataGridViewDoctorAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctorAppointments_CellDoubleClick);
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnOffice
            // 
            this.ColumnOffice.HeaderText = "Office";
            this.ColumnOffice.Name = "ColumnOffice";
            this.ColumnOffice.ReadOnly = true;
            // 
            // ColumnPatient
            // 
            this.ColumnPatient.HeaderText = "Patient";
            this.ColumnPatient.Name = "ColumnPatient";
            this.ColumnPatient.ReadOnly = true;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(0, 0);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(120, 28);
            this.comboBoxTime.TabIndex = 2;
            // 
            // comboBoxOffice
            // 
            this.comboBoxOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOffice.FormattingEnabled = true;
            this.comboBoxOffice.Location = new System.Drawing.Point(120, 0);
            this.comboBoxOffice.Name = "comboBoxOffice";
            this.comboBoxOffice.Size = new System.Drawing.Size(120, 28);
            this.comboBoxOffice.TabIndex = 3;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(240, 0);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(120, 28);
            this.comboBoxPatient.TabIndex = 4;
            // 
            // panelAppointmentDetails
            // 
            this.panelAppointmentDetails.Controls.Add(this.buttonExit);
            this.panelAppointmentDetails.Controls.Add(this.panelPatient);
            this.panelAppointmentDetails.Controls.Add(this.comboBoxTime);
            this.panelAppointmentDetails.Controls.Add(this.comboBoxOffice);
            this.panelAppointmentDetails.Controls.Add(this.comboBoxPatient);
            this.panelAppointmentDetails.Controls.Add(this.dataGridViewDoctorAppointments);
            this.panelAppointmentDetails.Location = new System.Drawing.Point(12, 12);
            this.panelAppointmentDetails.Name = "panelAppointmentDetails";
            this.panelAppointmentDetails.Size = new System.Drawing.Size(1124, 491);
            this.panelAppointmentDetails.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(0, 454);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(360, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Save changes and exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelPatient
            // 
            this.panelPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPatient.Controls.Add(this.label12);
            this.panelPatient.Controls.Add(this.btnClose);
            this.panelPatient.Controls.Add(this.btnSave);
            this.panelPatient.Controls.Add(this.labelTime);
            this.panelPatient.Controls.Add(this.labelChoosePatient);
            this.panelPatient.Controls.Add(this.comboBoxChoosePatient);
            this.panelPatient.Location = new System.Drawing.Point(393, 28);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(252, 202);
            this.panelPatient.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "(Dziala na dgv cell dwuklik)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(173, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "←";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(25, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save/Edit";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(25, 24);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(106, 20);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "(Display Time)";
            // 
            // labelChoosePatient
            // 
            this.labelChoosePatient.AutoSize = true;
            this.labelChoosePatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChoosePatient.Location = new System.Drawing.Point(25, 70);
            this.labelChoosePatient.Name = "labelChoosePatient";
            this.labelChoosePatient.Size = new System.Drawing.Size(112, 20);
            this.labelChoosePatient.TabIndex = 6;
            this.labelChoosePatient.Text = "Choose patient:";
            // 
            // comboBoxChoosePatient
            // 
            this.comboBoxChoosePatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoosePatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChoosePatient.FormattingEnabled = true;
            this.comboBoxChoosePatient.Location = new System.Drawing.Point(25, 93);
            this.comboBoxChoosePatient.Name = "comboBoxChoosePatient";
            this.comboBoxChoosePatient.Size = new System.Drawing.Size(197, 28);
            this.comboBoxChoosePatient.TabIndex = 5;
            // 
            // panelAppointmentCalendar
            // 
            this.panelAppointmentCalendar.Controls.Add(this.button1);
            this.panelAppointmentCalendar.Controls.Add(this.label11);
            this.panelAppointmentCalendar.Controls.Add(this.label9);
            this.panelAppointmentCalendar.Controls.Add(this.panel2);
            this.panelAppointmentCalendar.Controls.Add(this.label10);
            this.panelAppointmentCalendar.Controls.Add(this.panel3);
            this.panelAppointmentCalendar.Controls.Add(this.label7);
            this.panelAppointmentCalendar.Controls.Add(this.label6);
            this.panelAppointmentCalendar.Controls.Add(this.label5);
            this.panelAppointmentCalendar.Controls.Add(this.label4);
            this.panelAppointmentCalendar.Controls.Add(this.label3);
            this.panelAppointmentCalendar.Controls.Add(this.label2);
            this.panelAppointmentCalendar.Controls.Add(this.label1);
            this.panelAppointmentCalendar.Controls.Add(this.panel1);
            this.panelAppointmentCalendar.Controls.Add(this.btnViewCalendar);
            this.panelAppointmentCalendar.Controls.Add(this.dataGridViewDoctorCalendars);
            this.panelAppointmentCalendar.Controls.Add(this.labelDate);
            this.panelAppointmentCalendar.Controls.Add(this.daycontainer);
            this.panelAppointmentCalendar.Location = new System.Drawing.Point(12, 12);
            this.panelAppointmentCalendar.Name = "panelAppointmentCalendar";
            this.panelAppointmentCalendar.Size = new System.Drawing.Size(1142, 491);
            this.panelAppointmentCalendar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 72);
            this.button1.TabIndex = 34;
            this.button1.Text = "testowy przycisk do przechodzenia miedzy panelami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(721, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "(do usuniecia) zeby zmienic widok w projektancie na ten drugi panel to klikasz w " +
    "puste miejsce na jakis panel i klikasz \"Przesun na spod\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(842, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "← work scheduled";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(801, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 21);
            this.panel2.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(479, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "← work not scheduled";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Location = new System.Drawing.Point(438, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 21);
            this.panel3.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(283, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sunday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1039, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Saturday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(918, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(785, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(641, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(522, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tuesday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(394, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Monday";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 33);
            this.panel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Your active calendars";
            // 
            // btnViewCalendar
            // 
            this.btnViewCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewCalendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCalendar.Location = new System.Drawing.Point(0, 399);
            this.btnViewCalendar.Name = "btnViewCalendar";
            this.btnViewCalendar.Size = new System.Drawing.Size(204, 46);
            this.btnViewCalendar.TabIndex = 21;
            this.btnViewCalendar.Text = "View calendar";
            this.btnViewCalendar.UseVisualStyleBackColor = false;
            this.btnViewCalendar.Click += new System.EventHandler(this.btnViewCalendar_Click);
            // 
            // dataGridViewDoctorCalendars
            // 
            this.dataGridViewDoctorCalendars.AllowUserToAddRows = false;
            this.dataGridViewDoctorCalendars.AllowUserToDeleteRows = false;
            this.dataGridViewDoctorCalendars.AllowUserToResizeColumns = false;
            this.dataGridViewDoctorCalendars.AllowUserToResizeRows = false;
            this.dataGridViewDoctorCalendars.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewDoctorCalendars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDoctorCalendars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDoctorCalendars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorCalendars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCalendar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDoctorCalendars.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDoctorCalendars.Location = new System.Drawing.Point(1, 34);
            this.dataGridViewDoctorCalendars.MultiSelect = false;
            this.dataGridViewDoctorCalendars.Name = "dataGridViewDoctorCalendars";
            this.dataGridViewDoctorCalendars.ReadOnly = true;
            this.dataGridViewDoctorCalendars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDoctorCalendars.RowHeadersVisible = false;
            this.dataGridViewDoctorCalendars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDoctorCalendars.RowTemplate.Height = 25;
            this.dataGridViewDoctorCalendars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctorCalendars.Size = new System.Drawing.Size(203, 365);
            this.dataGridViewDoctorCalendars.TabIndex = 20;
            // 
            // ColumnCalendar
            // 
            this.ColumnCalendar.HeaderText = "Name";
            this.ColumnCalendar.Name = "ColumnCalendar";
            this.ColumnCalendar.ReadOnly = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(651, 7);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 21);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Date";
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(232, 64);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(906, 335);
            this.daycontainer.TabIndex = 11;
            // 
            // FormDoctorAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 515);
            this.Controls.Add(this.panelAppointmentCalendar);
            this.Controls.Add(this.panelAppointmentDetails);
            this.Name = "FormDoctorAppointments";
            this.Text = "FormDoctorsAppointments";
            this.Load += new System.EventHandler(this.FormDoctorAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorAppointments)).EndInit();
            this.panelAppointmentDetails.ResumeLayout(false);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.panelAppointmentCalendar.ResumeLayout(false);
            this.panelAppointmentCalendar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorCalendars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewDoctorAppointments;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnPatient;
        private ComboBox comboBoxTime;
        private ComboBox comboBoxOffice;
        private ComboBox comboBoxPatient;
        private Panel panelAppointmentDetails;
        private Panel panelPatient;
        private Button btnSave;
        private Label labelTime;
        private Label labelChoosePatient;
        private ComboBox comboBoxChoosePatient;
        private Button btnClose;
        private Button buttonExit;
        private Panel panelAppointmentCalendar;
        private Label labelDate;
        private DataGridView dataGridViewDoctorCalendars;
        private Panel panel1;
        private Label label8;
        private Button btnViewCalendar;
        private FlowLayoutPanel daycontainer;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnCalendar;
        private Label label9;
        private Panel panel2;
        private Label label10;
        private Panel panel3;
        private Label label11;
        private Button button1;
        private Label label12;
    }
}