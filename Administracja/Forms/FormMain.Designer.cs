namespace WinFormsApp1
{
    partial class FormMain
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
            pnlSideMenu = new Panel();
            pnlDoctorPanelSubmenu = new Panel();
            btnDoctorAppointments = new Button();
            btnDoctorCalendars = new Button();
            btnDoctorPanel = new Button();
            pnlCalendarSubMenu = new Panel();
            btnCalendarList = new Button();
            btnCalendar = new Button();
            pnlOfficeSubMenu = new Panel();
            btnOfficeAdd = new Button();
            btnOfficeList = new Button();
            btnOffice = new Button();
            pnlUsersSubMenu = new Panel();
            btnUsersAdd = new Button();
            btnUsersList = new Button();
            btnUser = new Button();
            btnLogout = new Button();
            pnlRoleSubmenu = new Panel();
            btnRoleAdd = new Button();
            btnRoleList = new Button();
            btnRole = new Button();
            pnlDoctorSubmenu = new Panel();
            btnDoctorAdd = new Button();
            btnDoctorList = new Button();
            btnDoctor = new Button();
            pnlEmployeeSubmenu = new Panel();
            btnEmployeeAdd = new Button();
            btnEmployeeList = new Button();
            btnEmployee = new Button();
            pnlLogo = new Panel();
            btnMenu = new Button();
            pnlChildForm = new Panel();
            pnlTitle = new Panel();
            labelTitle = new Label();
            pnlSideMenu.SuspendLayout();
            pnlDoctorPanelSubmenu.SuspendLayout();
            pnlCalendarSubMenu.SuspendLayout();
            pnlOfficeSubMenu.SuspendLayout();
            pnlUsersSubMenu.SuspendLayout();
            pnlRoleSubmenu.SuspendLayout();
            pnlDoctorSubmenu.SuspendLayout();
            pnlEmployeeSubmenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(23, 35, 49);
            pnlSideMenu.Controls.Add(pnlDoctorPanelSubmenu);
            pnlSideMenu.Controls.Add(btnDoctorPanel);
            pnlSideMenu.Controls.Add(pnlCalendarSubMenu);
            pnlSideMenu.Controls.Add(btnCalendar);
            pnlSideMenu.Controls.Add(pnlOfficeSubMenu);
            pnlSideMenu.Controls.Add(btnOffice);
            pnlSideMenu.Controls.Add(pnlUsersSubMenu);
            pnlSideMenu.Controls.Add(btnUser);
            pnlSideMenu.Controls.Add(btnLogout);
            pnlSideMenu.Controls.Add(pnlRoleSubmenu);
            pnlSideMenu.Controls.Add(btnRole);
            pnlSideMenu.Controls.Add(pnlDoctorSubmenu);
            pnlSideMenu.Controls.Add(btnDoctor);
            pnlSideMenu.Controls.Add(pnlEmployeeSubmenu);
            pnlSideMenu.Controls.Add(btnEmployee);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(250, 1069);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // pnlDoctorPanelSubmenu
            // 
            pnlDoctorPanelSubmenu.AllowDrop = true;
            pnlDoctorPanelSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlDoctorPanelSubmenu.Controls.Add(btnDoctorAppointments);
            pnlDoctorPanelSubmenu.Controls.Add(btnDoctorCalendars);
            pnlDoctorPanelSubmenu.Dock = DockStyle.Top;
            pnlDoctorPanelSubmenu.Location = new Point(0, 890);
            pnlDoctorPanelSubmenu.Name = "pnlDoctorPanelSubmenu";
            pnlDoctorPanelSubmenu.Size = new Size(250, 82);
            pnlDoctorPanelSubmenu.TabIndex = 15;
            pnlDoctorPanelSubmenu.Visible = false;
            // 
            // btnDoctorAppointments
            // 
            btnDoctorAppointments.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorAppointments.Dock = DockStyle.Top;
            btnDoctorAppointments.FlatAppearance.BorderSize = 0;
            btnDoctorAppointments.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAppointments.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAppointments.FlatStyle = FlatStyle.Flat;
            btnDoctorAppointments.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorAppointments.ForeColor = Color.WhiteSmoke;
            btnDoctorAppointments.Location = new Point(0, 40);
            btnDoctorAppointments.Name = "btnDoctorAppointments";
            btnDoctorAppointments.Padding = new Padding(35, 0, 0, 0);
            btnDoctorAppointments.Size = new Size(250, 40);
            btnDoctorAppointments.TabIndex = 1;
            btnDoctorAppointments.Tag = "Add";
            btnDoctorAppointments.Text = "Appointments";
            btnDoctorAppointments.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorAppointments.UseVisualStyleBackColor = false;
            btnDoctorAppointments.Click += btnDoctorAppointments_Click;
            // 
            // btnDoctorCalendars
            // 
            btnDoctorCalendars.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorCalendars.Dock = DockStyle.Top;
            btnDoctorCalendars.FlatAppearance.BorderSize = 0;
            btnDoctorCalendars.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorCalendars.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorCalendars.FlatStyle = FlatStyle.Flat;
            btnDoctorCalendars.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorCalendars.ForeColor = Color.WhiteSmoke;
            btnDoctorCalendars.Location = new Point(0, 0);
            btnDoctorCalendars.Name = "btnDoctorCalendars";
            btnDoctorCalendars.Padding = new Padding(35, 0, 0, 0);
            btnDoctorCalendars.Size = new Size(250, 40);
            btnDoctorCalendars.TabIndex = 0;
            btnDoctorCalendars.Tag = "List";
            btnDoctorCalendars.Text = "Calendars";
            btnDoctorCalendars.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorCalendars.UseVisualStyleBackColor = false;
            btnDoctorCalendars.Click += btnDoctorCalendars_Click;
            // 
            // btnDoctorPanel
            // 
            btnDoctorPanel.BackColor = Color.FromArgb(23, 35, 49);
            btnDoctorPanel.Dock = DockStyle.Top;
            btnDoctorPanel.FlatAppearance.BorderSize = 0;
            btnDoctorPanel.FlatStyle = FlatStyle.Flat;
            btnDoctorPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorPanel.ForeColor = Color.WhiteSmoke;
            btnDoctorPanel.Location = new Point(0, 845);
            btnDoctorPanel.Name = "btnDoctorPanel";
            btnDoctorPanel.Padding = new Padding(10, 0, 0, 0);
            btnDoctorPanel.Size = new Size(250, 45);
            btnDoctorPanel.TabIndex = 14;
            btnDoctorPanel.Tag = "Calendar";
            btnDoctorPanel.Text = "Doctor Panel";
            btnDoctorPanel.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorPanel.UseVisualStyleBackColor = false;
            btnDoctorPanel.Click += button1_Click;
            // 
            // pnlCalendarSubMenu
            // 
            pnlCalendarSubMenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlCalendarSubMenu.Controls.Add(btnCalendarList);
            pnlCalendarSubMenu.Dock = DockStyle.Top;
            pnlCalendarSubMenu.Location = new Point(0, 805);
            pnlCalendarSubMenu.Name = "pnlCalendarSubMenu";
            pnlCalendarSubMenu.Size = new Size(250, 40);
            pnlCalendarSubMenu.TabIndex = 13;
            pnlCalendarSubMenu.Paint += panel1_Paint;
            // 
            // btnCalendarList
            // 
            btnCalendarList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnCalendarList.Dock = DockStyle.Top;
            btnCalendarList.FlatAppearance.BorderSize = 0;
            btnCalendarList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnCalendarList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnCalendarList.FlatStyle = FlatStyle.Flat;
            btnCalendarList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendarList.ForeColor = Color.WhiteSmoke;
            btnCalendarList.Location = new Point(0, 0);
            btnCalendarList.Name = "btnCalendarList";
            btnCalendarList.Padding = new Padding(35, 0, 0, 0);
            btnCalendarList.Size = new Size(250, 40);
            btnCalendarList.TabIndex = 0;
            btnCalendarList.Tag = "List";
            btnCalendarList.Text = "List";
            btnCalendarList.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendarList.UseVisualStyleBackColor = false;
            btnCalendarList.Click += btnCalendarList_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(23, 35, 49);
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendar.ForeColor = Color.WhiteSmoke;
            btnCalendar.Location = new Point(0, 760);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(10, 0, 0, 0);
            btnCalendar.Size = new Size(250, 45);
            btnCalendar.TabIndex = 12;
            btnCalendar.Tag = "Calendar";
            btnCalendar.Text = "Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // pnlOfficeSubMenu
            // 
            pnlOfficeSubMenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlOfficeSubMenu.Controls.Add(btnOfficeAdd);
            pnlOfficeSubMenu.Controls.Add(btnOfficeList);
            pnlOfficeSubMenu.Dock = DockStyle.Top;
            pnlOfficeSubMenu.Location = new Point(0, 678);
            pnlOfficeSubMenu.Name = "pnlOfficeSubMenu";
            pnlOfficeSubMenu.Size = new Size(250, 82);
            pnlOfficeSubMenu.TabIndex = 11;
            // 
            // btnOfficeAdd
            // 
            btnOfficeAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnOfficeAdd.Dock = DockStyle.Top;
            btnOfficeAdd.FlatAppearance.BorderSize = 0;
            btnOfficeAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnOfficeAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnOfficeAdd.FlatStyle = FlatStyle.Flat;
            btnOfficeAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOfficeAdd.ForeColor = Color.WhiteSmoke;
            btnOfficeAdd.Location = new Point(0, 40);
            btnOfficeAdd.Name = "btnOfficeAdd";
            btnOfficeAdd.Padding = new Padding(35, 0, 0, 0);
            btnOfficeAdd.Size = new Size(250, 40);
            btnOfficeAdd.TabIndex = 1;
            btnOfficeAdd.Tag = "Add";
            btnOfficeAdd.Text = "Add";
            btnOfficeAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnOfficeAdd.UseVisualStyleBackColor = false;
            btnOfficeAdd.Click += btnOfficeAdd_Click_1;
            // 
            // btnOfficeList
            // 
            btnOfficeList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnOfficeList.Dock = DockStyle.Top;
            btnOfficeList.FlatAppearance.BorderSize = 0;
            btnOfficeList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnOfficeList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnOfficeList.FlatStyle = FlatStyle.Flat;
            btnOfficeList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOfficeList.ForeColor = Color.WhiteSmoke;
            btnOfficeList.Location = new Point(0, 0);
            btnOfficeList.Name = "btnOfficeList";
            btnOfficeList.Padding = new Padding(35, 0, 0, 0);
            btnOfficeList.Size = new Size(250, 40);
            btnOfficeList.TabIndex = 0;
            btnOfficeList.Tag = "List";
            btnOfficeList.Text = "List";
            btnOfficeList.TextAlign = ContentAlignment.MiddleLeft;
            btnOfficeList.UseVisualStyleBackColor = false;
            btnOfficeList.Click += btnOfficeList_Click_1;
            // 
            // btnOffice
            // 
            btnOffice.BackColor = Color.FromArgb(23, 35, 49);
            btnOffice.Dock = DockStyle.Top;
            btnOffice.FlatAppearance.BorderSize = 0;
            btnOffice.FlatStyle = FlatStyle.Flat;
            btnOffice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOffice.ForeColor = Color.WhiteSmoke;
            btnOffice.Location = new Point(0, 633);
            btnOffice.Name = "btnOffice";
            btnOffice.Padding = new Padding(10, 0, 0, 0);
            btnOffice.Size = new Size(250, 45);
            btnOffice.TabIndex = 10;
            btnOffice.Tag = "Office";
            btnOffice.Text = "Office";
            btnOffice.TextAlign = ContentAlignment.MiddleLeft;
            btnOffice.UseVisualStyleBackColor = false;
            btnOffice.Click += btnOffice_Click;
            // 
            // pnlUsersSubMenu
            // 
            pnlUsersSubMenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlUsersSubMenu.Controls.Add(btnUsersAdd);
            pnlUsersSubMenu.Controls.Add(btnUsersList);
            pnlUsersSubMenu.Dock = DockStyle.Top;
            pnlUsersSubMenu.Location = new Point(0, 551);
            pnlUsersSubMenu.Name = "pnlUsersSubMenu";
            pnlUsersSubMenu.Size = new Size(250, 82);
            pnlUsersSubMenu.TabIndex = 9;
            // 
            // btnUsersAdd
            // 
            btnUsersAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnUsersAdd.Dock = DockStyle.Top;
            btnUsersAdd.FlatAppearance.BorderSize = 0;
            btnUsersAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnUsersAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnUsersAdd.FlatStyle = FlatStyle.Flat;
            btnUsersAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsersAdd.ForeColor = Color.WhiteSmoke;
            btnUsersAdd.Location = new Point(0, 40);
            btnUsersAdd.Name = "btnUsersAdd";
            btnUsersAdd.Padding = new Padding(35, 0, 0, 0);
            btnUsersAdd.Size = new Size(250, 40);
            btnUsersAdd.TabIndex = 1;
            btnUsersAdd.Tag = "Add";
            btnUsersAdd.Text = "Add";
            btnUsersAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnUsersAdd.UseVisualStyleBackColor = false;
            btnUsersAdd.Click += btnUsersAdd_Click;
            // 
            // btnUsersList
            // 
            btnUsersList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnUsersList.Dock = DockStyle.Top;
            btnUsersList.FlatAppearance.BorderSize = 0;
            btnUsersList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnUsersList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnUsersList.FlatStyle = FlatStyle.Flat;
            btnUsersList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsersList.ForeColor = Color.WhiteSmoke;
            btnUsersList.Location = new Point(0, 0);
            btnUsersList.Name = "btnUsersList";
            btnUsersList.Padding = new Padding(35, 0, 0, 0);
            btnUsersList.Size = new Size(250, 40);
            btnUsersList.TabIndex = 0;
            btnUsersList.Tag = "List";
            btnUsersList.Text = "List";
            btnUsersList.TextAlign = ContentAlignment.MiddleLeft;
            btnUsersList.UseVisualStyleBackColor = false;
            btnUsersList.Click += btnUsersList_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(23, 35, 49);
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.WhiteSmoke;
            btnUser.Location = new Point(0, 506);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.Size = new Size(250, 45);
            btnUser.TabIndex = 8;
            btnUser.Tag = "User";
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(23, 35, 49);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.WhiteSmoke;
            btnLogout.Location = new Point(0, 1025);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(250, 44);
            btnLogout.TabIndex = 7;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlRoleSubmenu
            // 
            pnlRoleSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlRoleSubmenu.Controls.Add(btnRoleAdd);
            pnlRoleSubmenu.Controls.Add(btnRoleList);
            pnlRoleSubmenu.Dock = DockStyle.Top;
            pnlRoleSubmenu.Location = new Point(0, 424);
            pnlRoleSubmenu.Name = "pnlRoleSubmenu";
            pnlRoleSubmenu.Size = new Size(250, 82);
            pnlRoleSubmenu.TabIndex = 6;
            // 
            // btnRoleAdd
            // 
            btnRoleAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnRoleAdd.Dock = DockStyle.Top;
            btnRoleAdd.FlatAppearance.BorderSize = 0;
            btnRoleAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnRoleAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnRoleAdd.FlatStyle = FlatStyle.Flat;
            btnRoleAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoleAdd.ForeColor = Color.WhiteSmoke;
            btnRoleAdd.Location = new Point(0, 40);
            btnRoleAdd.Name = "btnRoleAdd";
            btnRoleAdd.Padding = new Padding(35, 0, 0, 0);
            btnRoleAdd.Size = new Size(250, 40);
            btnRoleAdd.TabIndex = 1;
            btnRoleAdd.Tag = "Add";
            btnRoleAdd.Text = "Add";
            btnRoleAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnRoleAdd.UseVisualStyleBackColor = false;
            btnRoleAdd.Click += btnRoleAdd_Click;
            // 
            // btnRoleList
            // 
            btnRoleList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnRoleList.Dock = DockStyle.Top;
            btnRoleList.FlatAppearance.BorderSize = 0;
            btnRoleList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnRoleList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnRoleList.FlatStyle = FlatStyle.Flat;
            btnRoleList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoleList.ForeColor = Color.WhiteSmoke;
            btnRoleList.Location = new Point(0, 0);
            btnRoleList.Name = "btnRoleList";
            btnRoleList.Padding = new Padding(35, 0, 0, 0);
            btnRoleList.Size = new Size(250, 40);
            btnRoleList.TabIndex = 0;
            btnRoleList.Tag = "List";
            btnRoleList.Text = "List";
            btnRoleList.TextAlign = ContentAlignment.MiddleLeft;
            btnRoleList.UseVisualStyleBackColor = false;
            btnRoleList.Click += btnRoleList_Click;
            // 
            // btnRole
            // 
            btnRole.BackColor = Color.FromArgb(23, 35, 49);
            btnRole.Dock = DockStyle.Top;
            btnRole.FlatAppearance.BorderSize = 0;
            btnRole.FlatStyle = FlatStyle.Flat;
            btnRole.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRole.ForeColor = Color.WhiteSmoke;
            btnRole.Location = new Point(0, 379);
            btnRole.Name = "btnRole";
            btnRole.Padding = new Padding(10, 0, 0, 0);
            btnRole.Size = new Size(250, 45);
            btnRole.TabIndex = 5;
            btnRole.Tag = "Role";
            btnRole.Text = "Role";
            btnRole.TextAlign = ContentAlignment.MiddleLeft;
            btnRole.UseVisualStyleBackColor = false;
            btnRole.Click += btnRole_Click;
            // 
            // pnlDoctorSubmenu
            // 
            pnlDoctorSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlDoctorSubmenu.Controls.Add(btnDoctorAdd);
            pnlDoctorSubmenu.Controls.Add(btnDoctorList);
            pnlDoctorSubmenu.Dock = DockStyle.Top;
            pnlDoctorSubmenu.Location = new Point(0, 298);
            pnlDoctorSubmenu.Name = "pnlDoctorSubmenu";
            pnlDoctorSubmenu.Size = new Size(250, 81);
            pnlDoctorSubmenu.TabIndex = 4;
            // 
            // btnDoctorAdd
            // 
            btnDoctorAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorAdd.Dock = DockStyle.Top;
            btnDoctorAdd.FlatAppearance.BorderSize = 0;
            btnDoctorAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatStyle = FlatStyle.Flat;
            btnDoctorAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorAdd.ForeColor = Color.WhiteSmoke;
            btnDoctorAdd.Location = new Point(0, 40);
            btnDoctorAdd.Name = "btnDoctorAdd";
            btnDoctorAdd.Padding = new Padding(35, 0, 0, 0);
            btnDoctorAdd.Size = new Size(250, 40);
            btnDoctorAdd.TabIndex = 1;
            btnDoctorAdd.Tag = "Add";
            btnDoctorAdd.Text = "Add";
            btnDoctorAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorAdd.UseVisualStyleBackColor = false;
            btnDoctorAdd.Click += btnDoctorAdd_Click;
            // 
            // btnDoctorList
            // 
            btnDoctorList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorList.Dock = DockStyle.Top;
            btnDoctorList.FlatAppearance.BorderSize = 0;
            btnDoctorList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatStyle = FlatStyle.Flat;
            btnDoctorList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorList.ForeColor = Color.WhiteSmoke;
            btnDoctorList.Location = new Point(0, 0);
            btnDoctorList.Name = "btnDoctorList";
            btnDoctorList.Padding = new Padding(35, 0, 0, 0);
            btnDoctorList.Size = new Size(250, 40);
            btnDoctorList.TabIndex = 0;
            btnDoctorList.Tag = "List";
            btnDoctorList.Text = "List";
            btnDoctorList.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorList.UseVisualStyleBackColor = false;
            btnDoctorList.Click += btnDoctorList_Click_1;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.FromArgb(23, 35, 49);
            btnDoctor.Dock = DockStyle.Top;
            btnDoctor.FlatAppearance.BorderSize = 0;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctor.ForeColor = Color.WhiteSmoke;
            btnDoctor.Location = new Point(0, 253);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Padding = new Padding(10, 0, 0, 0);
            btnDoctor.Size = new Size(250, 45);
            btnDoctor.TabIndex = 3;
            btnDoctor.Tag = "Doctor’s specializations";
            btnDoctor.Text = "Doctor’s specializations";
            btnDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // pnlEmployeeSubmenu
            // 
            pnlEmployeeSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeAdd);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeList);
            pnlEmployeeSubmenu.Dock = DockStyle.Top;
            pnlEmployeeSubmenu.Location = new Point(0, 170);
            pnlEmployeeSubmenu.Name = "pnlEmployeeSubmenu";
            pnlEmployeeSubmenu.Size = new Size(250, 83);
            pnlEmployeeSubmenu.TabIndex = 2;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeAdd.Dock = DockStyle.Top;
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeAdd.ForeColor = Color.WhiteSmoke;
            btnEmployeeAdd.Location = new Point(0, 40);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeAdd.Size = new Size(250, 40);
            btnEmployeeAdd.TabIndex = 1;
            btnEmployeeAdd.Tag = "Add";
            btnEmployeeAdd.Text = "Add";
            btnEmployeeAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click_1;
            // 
            // btnEmployeeList
            // 
            btnEmployeeList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeList.Dock = DockStyle.Top;
            btnEmployeeList.FlatAppearance.BorderSize = 0;
            btnEmployeeList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatStyle = FlatStyle.Flat;
            btnEmployeeList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeList.ForeColor = Color.WhiteSmoke;
            btnEmployeeList.Location = new Point(0, 0);
            btnEmployeeList.Name = "btnEmployeeList";
            btnEmployeeList.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeList.Size = new Size(250, 40);
            btnEmployeeList.TabIndex = 0;
            btnEmployeeList.Tag = "List";
            btnEmployeeList.Text = "List";
            btnEmployeeList.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeList.UseVisualStyleBackColor = false;
            btnEmployeeList.Click += btnEmployeeList_Click_1;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(23, 35, 49);
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.WhiteSmoke;
            btnEmployee.Location = new Point(0, 125);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(10, 0, 0, 0);
            btnEmployee.Size = new Size(250, 45);
            btnEmployee.TabIndex = 1;
            btnEmployee.Tag = "Employee";
            btnEmployee.Text = "Employee";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(23, 35, 49);
            pnlLogo.Controls.Add(btnMenu);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 125);
            pnlLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Image = Administracja.Properties.Resources.toggle1;
            btnMenu.Location = new Point(181, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(66, 53);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click_1;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = SystemColors.Control;
            pnlChildForm.Location = new Point(250, 125);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1164, 680);
            pnlChildForm.TabIndex = 1;
            pnlChildForm.Paint += pnlChildForm_Paint_1;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(23, 35, 49);
            pnlTitle.Controls.Add(labelTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(250, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1176, 125);
            pnlTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(103, 36);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(131, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Home";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 1069);
            Controls.Add(pnlTitle);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(950, 600);
            Name = "FormMain";
            Text = "Medical clinic";
            pnlSideMenu.ResumeLayout(false);
            pnlDoctorPanelSubmenu.ResumeLayout(false);
            pnlCalendarSubMenu.ResumeLayout(false);
            pnlOfficeSubMenu.ResumeLayout(false);
            pnlUsersSubMenu.ResumeLayout(false);
            pnlRoleSubmenu.ResumeLayout(false);
            pnlDoctorSubmenu.ResumeLayout(false);
            pnlEmployeeSubmenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Button btnLogout;
        private Panel pnlRoleSubmenu;
        private Button btnRoleAdd;
        private Button btnDoctor;
        private Panel pnlEmployeeSubmenu;
        private Button btnEmployeeAdd;
        private Button btnEmployeeList;
        private Button btnEmployee;
        private Panel pnlLogo;
        private Panel pnlChildForm;
        private Panel pnlTitle;
        private Button btnRoleList;
        private Button btnRole;
        private Panel pnlDoctorSubmenu;
        private Button btnDoctorAdd;
        private Button btnDoctorList;
        private Button btnMenu;
        private Label labelTitle;
        private Panel pnlUsersSubMenu;
        private Button btnUsersAdd;
        private Button btnUsersList;
        private Button btnUser;
        private Panel pnlCalendarSubMenu;
        private Button btnCalendarList;
        private Button btnCalendar;
        private Panel pnlOfficeSubMenu;
        private Button btnOfficeAdd;
        private Button btnOfficeList;
        private Button btnOffice;
        private Button btnDoctorPanel;
        private Panel pnlDoctorPanelSubmenu;
        private Button btnDoctorAppointments;
        private Button btnDoctorCalendars;
    }
}