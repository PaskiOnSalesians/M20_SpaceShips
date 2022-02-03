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
        List<string> SpaceshipBp = new List<string>();

        List<string> FrontView = new List<string>();
        List<string> SideView = new List<string>();
        List<string> TopView = new List<string>();
        List<string> RearView = new List<string>();
        List<string> View360 = new List<string>();

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

            foreach (XElement n in blueprints.Descendants("Blueprint"))
            {
                SpaceshipBp.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("FrontView"))
            {
                FrontView.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("SideView"))
            {
                SideView.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("TopView"))
            {
                TopView.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("RearView"))
            {
                RearView.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("View360"))
            {
                View360.Add(n.Value);
            }
        }

        private void cmbNaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNaus.SelectedIndex;
            int Idindex = SpaceshipId[index];

            string imagepath = resourcesPath + "\\" + cmbNaus.Text + "\\";

            lblInfo.Text = SpaceshipInfo[Idindex];
            lblSpaceshipName.Text = cmbNaus.Text;

            picBlueprints.ImageLocation = imagepath + SpaceshipBp[Idindex];

            picSpace1.ImageLocation = imagepath + FrontView[Idindex];
            picSpace2.ImageLocation = imagepath + SideView[Idindex];
            picSpace3.ImageLocation = imagepath + TopView[Idindex];
            picSpace4.ImageLocation = imagepath + RearView[Idindex];
            picSpace4.ImageLocation = imagepath + View360[Idindex];
        }
    }
}
