using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BlueprintsInfoDC
{
    public partial class frmSpaceship : Form
    {
        public frmSpaceship()
        {
            InitializeComponent();
        }

        List<string> SpaceshipInfo = new List<string>();
        List<string> SpaceshipIcon = new List<string>();


        private void frmSpaceship_Load(object sender, EventArgs e)
        {
            string XMLfilePath = "\\\\Mac\\Home\\Desktop\\GitHub\\M20-SpaceShips\\BlueprintsInfoDC\\Resources\\info.xml";

            XElement blueprints = XElement.Load(XMLfilePath);

            foreach (XElement n in blueprints.Descendants("textOption"))
            {
                cmbNaus.Items.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("textInfoDetail"))
            {
                SpaceshipInfo.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("icon"))
            {
                SpaceshipIcon.Add(n.Value);
            }
        }

        private void cmbNaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNaus.SelectedIndex;
            lblInfo.Text = SpaceshipInfo[index];
            picSpaceship.ImageLocation = "\\\\Mac\\Home\\Desktop\\GitHub\\M20-SpaceShips\\BlueprintsInfoDC\\Resources\\" + cmbNaus.Text + "\\" + SpaceshipIcon;
        }
    }
}
