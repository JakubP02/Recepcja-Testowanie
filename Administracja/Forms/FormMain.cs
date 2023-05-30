using Administracja.Forms;
using Administracja.FormsCalendar;
using Administracja.FormsDoctor;
using Patient_Handling;
using Recepcja;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            customizeDesing();
            //CollapseMenu();
            btnMenu.Visible = false;
        }

        private void customizeDesing()
        {
            pnlEmployeeSubmenu.Visible = false;
            pnlDoctorSubmenu.Visible = false;
            pnlRoleSubmenu.Visible = false;
            pnlUsersSubMenu.Visible = false;
            pnlEmployeeSubmenu.Visible = false;
            pnlOfficeSubMenu.Visible = false;
            pnlCalendarSubMenu.Visible = false;
            pnlRoleSubmenu.Visible = false;
            pnlPatientSubmenu.Visible = false;
        }



        private void hideSubMenu()
        {
            if (pnlEmployeeSubmenu.Visible == true)
                pnlEmployeeSubmenu.Visible = false;

            if (pnlDoctorSubmenu.Visible == true)
                pnlDoctorSubmenu.Visible = false;

            if (pnlRoleSubmenu.Visible == true)
                pnlRoleSubmenu.Visible = false;

            if (pnlUsersSubMenu.Visible == true)
                pnlUsersSubMenu.Visible = false;

            if (pnlOfficeSubMenu.Visible == true)
                pnlOfficeSubMenu.Visible = false;


            if (pnlCalendarSubMenu.Visible == true)
                pnlCalendarSubMenu.Visible = false;

            if (pnlPatientSubmenu.Visible == true)
                pnlPatientSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        #region EmployeeSubmenu
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEmployee());
            showSubMenu(pnlEmployeeSubmenu);
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEmployeeList());
            hideSubMenu();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormAddEmployee());
            hideSubMenu();
        }

        private void btnEmployeeDeactivate_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormDeactivate());
            hideSubMenu();
        }
        #endregion

        private Form? activeForm = null;
        public void openChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childFrom);
            pnlChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }

        private void btnEmployeeList_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormEmployeeList(this));
            labelTitle.Text = "Employee List";
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlEmployeeSubmenu);
            //openChildForm(new FormEmployee(this));
        }

        private void btnEmployeeAdd_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormAddEmployee(this));
            labelTitle.Text = "Employee Add";
        }


        private void btnRole_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRoleSubmenu);
            //openChildForm(new FormRole(this));
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDoctorSubmenu);
            //openChildForm(new FormDoctors(this));
        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormDoctorsList(this));
            labelTitle.Text = "Doctor’s specializations List";
        }

        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSpecializationManage(this));
            labelTitle.Text = "Doctor’s specializations Add";
        }

        private void btnRoleList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRolesList(this));
            labelTitle.Text = "Role List";
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRoleManage(this));
            labelTitle.Text = "Role Add";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.pnlSideMenu.Width > 200)
            {
                pnlSideMenu.Width = 100;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in pnlSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Visible = false;
                }
                foreach (Button menuButton in pnlEmployeeSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Visible = false;
                    pnlEmployeeSubmenu.Visible = false;
                }
                foreach (Button menuButton in pnlDoctorSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Visible = false;
                    pnlDoctorSubmenu.Visible = false;
                }
                foreach (Button menuButton in pnlRoleSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Visible = false;
                    pnlRoleSubmenu.Visible = false;
                }
                foreach (Button menuButton in pnlUsersSubMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Visible = false;
                    pnlRoleSubmenu.Visible = false;
                }
            }
            else
            {
                pnlSideMenu.Width = 250;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag as string;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Visible = true;
                }

                foreach (Button menuButton in pnlEmployeeSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag as string;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Visible = true;
                }
                foreach (Button menuButton in pnlDoctorSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag as string;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Visible = true;
                }
                foreach (Button menuButton in pnlRoleSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag as string;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Visible = true;
                }
                foreach (Button menuButton in pnlUsersSubMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag as string;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Visible = true;
                }
            }


        }

        private void btnDoctorList_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormSpecializationsList(this));
            labelTitle.Text = "List of Specializations";
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlUsersSubMenu);
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsersList(this));
            labelTitle.Text = "Users List";
        }

        private void btnUsersAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddUsers(this));
            labelTitle.Text = "Users Add";
        }

        private void pnlChildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void changeMainLabelText(string text)
        {
            labelTitle.Text = text;
        }

        private void buttonGenerateCalendar_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddCalendarEntity(this));
            labelTitle.Text = "Calendar";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOfficeList_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormOfficeList(this));
            labelTitle.Text = "Office List";
        }

        private void btnOfficeAdd_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormAddOffice(this));
            labelTitle.Text = "Office Add";
        }

        private void btnCalendarList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCalendarList(this));
            labelTitle.Text = "Calendar";
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlOfficeSubMenu);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCalendarSubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDoctorPanelSubmenu);
        }

        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoctorCalendars_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDoctorCalendars(this));
        }

        private void btnDoctorAppointments_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDoctorAppointments(this));
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlPatientSubmenu);
        }

        private void btnPatientAdd_Click_1(object sender, EventArgs e)
        {
            Form_reception_menu formreceptionmenu = new Form_reception_menu();
            Form_add_patient formAddPatient = new Form_add_patient(formreceptionmenu);
            formAddPatient.TopLevel = false;
            formAddPatient.FormBorderStyle = FormBorderStyle.None;
            formAddPatient.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(formAddPatient);
            pnlChildForm.Tag = formAddPatient;
            formAddPatient.BringToFront();
            formAddPatient.Show();
        }

        private void btnPatientFilterData_Click_1(object sender, EventArgs e)
        {
            Form_filter_data formfilterdata = new Form_filter_data();
            formfilterdata.TopLevel = false;
            formfilterdata.FormBorderStyle = FormBorderStyle.None;
            formfilterdata.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(formfilterdata);
            pnlChildForm.Tag = formfilterdata;
            formfilterdata.BringToFront();
            formfilterdata.Show();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            Form_reception_menu formReceptionMenu = new Form_reception_menu();
            formReceptionMenu.TopLevel = false;
            formReceptionMenu.FormBorderStyle = FormBorderStyle.None;
            formReceptionMenu.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(formReceptionMenu);
            pnlChildForm.Tag = formReceptionMenu;
            formReceptionMenu.BringToFront();
            formReceptionMenu.Show();

        }

        private void btnPatientEditPatientData_Click(object sender, EventArgs e)
        {

        }
    }
}