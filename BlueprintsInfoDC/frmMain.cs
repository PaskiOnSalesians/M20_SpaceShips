using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Net.Configuration;

namespace BlueprintsInfoDC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmBlueprints frm = new frmBlueprints();
            frm.Show();
        }

        private void btnSpaceship_Click(object sender, EventArgs e)
        {
            frmSpaceship frm = new frmSpaceship();
            frm.Show();
        }
    }
}
