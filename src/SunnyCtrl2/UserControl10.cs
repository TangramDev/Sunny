﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cosmos;
namespace SunnyCtrl2
{
    public partial class UserControl10 : UserControl
    {
        Grid hostGrid = null;
        public UserControl10()
        {
            InitializeComponent();
        }

        private void UserControl10_Load(object sender, EventArgs e)
        {
            if (Hubble.CreatingGrid != null)
            {
                hostGrid = Hubble.CreatingGrid;
                hostGrid.OnCloudMessageReceived += HostGrid_OnCloudMessageReceived;
            }
        }

        private void HostGrid_OnCloudMessageReceived(Wormhole cloudSession)
        {
        }
    }
}