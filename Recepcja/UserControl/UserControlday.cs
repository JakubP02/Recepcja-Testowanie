using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class UserControlday : UserControl
    {
        public static string static_day;
        public UserControlday()
        {
            InitializeComponent();
        }

        private void UserControlday_Load(object sender, EventArgs e)
        {

        }
        public void Day(int numday)
        {
            labelday.Text = numday + "";
        }

        public void UserControlday_Click(object sender, EventArgs e)
        {
            static_day = labelday.Text;
            addNewVisit addnewvisit = new addNewVisit();
            addnewvisit.Show();


        }

        public void changeLabelColor(Color color)
        {
            labelday.ForeColor = color;
        }
    }
}
