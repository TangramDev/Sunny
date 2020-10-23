/********************************************************************************
*					Sunny - version 1.0.0.8							*
*********************************************************************************
* Copyright (C) 2002-2020 by Tangram Team.   All Rights Reserved.				*
*
* This SOURCE CODE is governed by a BSD - style license that can be
* found in the LICENSE file.
*
* CONTACT INFORMATION:
* mailto:tangramteam@outlook.com
* https://www.tangram.dev
********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cosmos;

namespace SunnyForms
{
    public partial class Form4 : Form
    {
        Grid hostGrid = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
