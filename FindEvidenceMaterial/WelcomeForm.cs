﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace FindEvidenceMaterial
{
    public partial class WelcomeForm : MaterialForm
    {
        public WelcomeForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void BTN_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if(file.ShowDialog() == DialogResult.OK)
            {
                string path = file.FileName;
                TB_Path.Text = path;
            }
        }

        private void BTN_Upload_Click(object sender, EventArgs e)
        {
            Utilities.SettingsPath = TB_Path.Text;
            Utilities.ReadSettings();
            LBL_MaxSize.Text = $"* Maximum Size Allowed: {Utilities.MaxX} X {Utilities.MaxY}";
        }

        private void PB_Fingerprint_MouseEnter(object sender, EventArgs e)
        {
            PB_Fingerprint.Visible = true;
        }

        private void PB_Fingerprint_MouseExit(object sender, EventArgs e)
        {
            PB_Fingerprint.Visible = false;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
