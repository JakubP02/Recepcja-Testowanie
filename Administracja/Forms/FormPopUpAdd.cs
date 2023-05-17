using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracja.Forms
{
    public partial class FormPopUpAdd : Form
    {
        public FormPopUpAdd(string info)
        {
            InitializeComponent();
            labelText.Text = info;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
