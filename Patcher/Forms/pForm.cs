﻿using FX.Patcher.Source_files;
using System;
using System.Windows.Forms;

namespace FX.Patcher
{
    public partial class pForm : Form
    {
        public pForm()
        {
            InitializeComponent();

            Globals.pForm = this;
        }

        private void pForm_Shown(object sender, EventArgs e)
        {
            if (Common.IsGameRunning())
                Common.EnableStart();
            else
                Networking.CheckNetwork();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Starter.Start();
            pInfo info = new pInfo();
            info.Show();
        }
    }
}
