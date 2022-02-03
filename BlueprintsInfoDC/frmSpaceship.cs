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
        string XMLfilePath = "..\\..\\Resources\\info.xml";

        string resourcesPath = "..\\..\\Resources\\";


        List<int> SpaceshipId = new List<int>();
        List<string> SpaceshipInfo = new List<string>();
        List<string> SpaceshipPicture = new List<string>();

        private void frmSpaceship_Load(object sender, EventArgs e)
        {
            XElement blueprints = XElement.Load(XMLfilePath);

            foreach (XElement n in blueprints.Descendants("idInfoDetail"))
            {
                SpaceshipId.Add(Int16.Parse(n.Value));
            }

            foreach (XElement n in blueprints.Descendants("textOption"))
            {
                cmbNaus.Items.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("textInfoDetail"))
            {
                SpaceshipInfo.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("GeneralView"))
            {
                SpaceshipPicture.Add(n.Value);
            }
        }

        private void cmbNaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNaus.SelectedIndex;

            lblInfo.Text = SpaceshipInfo[index];

            picBlueprints.ImageLocation = resourcesPath + "\\" + cmbNaus.Text + "\\" + SpaceshipPicture[index];
        }
    }
}
