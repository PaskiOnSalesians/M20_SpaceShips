using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BlueprintsInfoDC
{
    public partial class frmBlueprints : Form
    {
        public frmBlueprints()
        {
            InitializeComponent();
        }

        List<string> DetailsTitles = new List<string>();
        List<string> TextDetails = new List<string>();
        List<string> ImageDetails = new List<string>();

        string ResourcesPath = "\\\\Mac\\Home\\Desktop\\GitHub\\M20-SpaceShips\\BlueprintsInfoDC\\Resources\\StarKiller\\";

        private void frmBlueprints_Load_1(object sender, EventArgs e)
        {
            string XMLfilePath = "\\\\Mac\\Home\\Desktop\\GitHub\\M20-SpaceShips\\BlueprintsInfoDC\\Resources\\info.xml";

            XElement blueprints = XElement.Load(XMLfilePath);

            foreach (XElement n in blueprints.Descendants("title").Take(3))
            {
                DetailsTitles.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("textDetail").Take(3))
            {
                TextDetails.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("imageDetail").Take(3))
            {
                ImageDetails.Add(n.Value);
            }
        }

        private void labelTransparent1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[0];
            lblText.Text = TextDetails[0];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[0]);
        }

        private void labelTransparent3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[1];
            lblText.Text = TextDetails[1];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[1]);
        }

        private void labelTransparent2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[2];
            lblText.Text = TextDetails[2];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[2]);
        }
    }
}
