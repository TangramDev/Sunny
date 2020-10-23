/********************************************************************************
*					Sunny - version 1.0.0.4							*
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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cosmos;

namespace SunnyCtrl
{
    public partial class UserControl5 : UserControl
    {
        Grid thisGrid = null;
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            thisGrid = Hubble.CreatingGrid;
            thisGrid.OnCloudMessageReceived += ThisGrid_OnCloudMessageReceived;
        }

        private void ThisGrid_OnCloudMessageReceived(Wormhole cloudSession)
        {
        }
    }
}
