﻿using System;
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

        string resourcesPath = Application.StartupPath + "\\Resources";



        List<int> SpaceshipId = new List<int>();
        List<string> SpaceshipInfo = new List<string>();
        List<string> SpaceshipBp = new List<string>();

        List<string> FrontView = new List<string>();
        List<string> SideView = new List<string>();
        List<string> TopView = new List<string>();
        List<string> RearView = new List<string>();
        List<string> View360 = new List<string>();
        List<string> GeneralView = new List<string>();

        List<string> Manufacturers = new List<string>();
        List<string> Length = new List<string>();
        List<string> Speed = new List<string>();
        List<string> Hyperdrive = new List<string>();
        List<string> Shielding = new List<string>();
        List<string> Armament = new List<string>();


        private void frmSpaceship_Load(object sender, EventArgs e)
        {
            axWMPvideo.uiMode = "none";
            XElement blueprints = XElement.Load(resourcesPath + "\\info.xml");

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

            foreach (XElement n in blueprints.Descendants("GeneralView"))
            {
                GeneralView.Add(n.Value);
            }

            // Data
            foreach (XElement n in blueprints.Descendants("Manufacturer"))
            {
                Manufacturers.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("Length"))
            {
                Length.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("Speed"))
            {
                Speed.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("Hyperdrive"))
            {
                Hyperdrive.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("Shielding"))
            {
                Shielding.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("Armament"))
            {
                Armament.Add(n.Value);
            }
        }

        private void cmbNaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNaus.SelectedIndex;
            int Idindex = SpaceshipId[index];

            string imagepath = resourcesPath + "\\" + cmbNaus.Text + "\\";

            lblInfo.Text = SpaceshipInfo[Idindex];
            lblSpaceshipName.Text = cmbNaus.Text;

            DataTable table = new DataTable();

            table.Columns.Add("DATA", typeof(string));
            table.Columns.Add("VALUE", typeof(string));

            table.Rows.Add("Manufacturer", Manufacturers[Idindex]);
            table.Rows.Add("Length", Length[Idindex]);
            table.Rows.Add("Speed", Speed[Idindex]);
            table.Rows.Add("Hyperdrive", Hyperdrive[Idindex]);
            table.Rows.Add("Shielding", Shielding[Idindex]);
            table.Rows.Add("Armament", Armament[Idindex]);

            dgv_ship_data.ForeColor = Color.Black;
            dgv_ship_data.DataSource = table;


            #region ImagesLocations
            picBlueprints.ImageLocation = imagepath + SpaceshipBp[Idindex];

            picSpaceMain.ImageLocation = "";
            picSpace1.ImageLocation = imagepath + FrontView[Idindex];
            picSpace2.ImageLocation = imagepath + SideView[Idindex];
            picSpace3.ImageLocation = imagepath + TopView[Idindex];
            picSpace4.ImageLocation = imagepath + RearView[Idindex];
            picSpace5.ImageLocation = imagepath + View360[Idindex];
            #endregion
        }

        private void picSpace1_Click(object sender, EventArgs e)
        {
            pnlImage.BringToFront();
            picSpaceMain.ImageLocation = picSpace1.ImageLocation;
        }

        private void picSpace2_Click(object sender, EventArgs e)
        {
            pnlImage.BringToFront();
            picSpaceMain.ImageLocation = picSpace2.ImageLocation;
        }

        private void picSpace3_Click(object sender, EventArgs e)
        {
            pnlImage.BringToFront();
            picSpaceMain.ImageLocation = picSpace3.ImageLocation;
        }

        private void picSpace4_Click(object sender, EventArgs e)
        {
            pnlImage.BringToFront();
            picSpaceMain.ImageLocation = picSpace4.ImageLocation;
        }

        private void picSpace5_Click(object sender, EventArgs e)
        {
            int index = cmbNaus.SelectedIndex;
            int Idindex = SpaceshipId[index];

            string path = resourcesPath + "\\" + cmbNaus.Text + "\\" + GeneralView[Idindex];
            pnlMedia.BringToFront();
            picSpaceMain.ImageLocation = "";

            axWMPvideo.URL = path;
            axWMPvideo.settings.setMode("loop", true);
            axWMPvideo.Visible = true;
            axWMPvideo.Ctlcontrols.play();
        }
    }
}
