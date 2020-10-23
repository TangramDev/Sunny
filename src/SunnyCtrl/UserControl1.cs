/********************************************************************************
*					Sunny - version 1.0.0.5							*
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
    public partial class UserControl1 : UserControl
    {
        Grid hostGrid = null;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hostGrid != null)
            {
                hostGrid.Wormhole.InsertString("msgID", "UserControl1_testButton1_click");
                hostGrid.Wormhole.InsertString("testVal", "this is a test for Usercontrol1");
                hostGrid.Wormhole.SendMessage();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (Hubble.CreatingGrid != null)
            {
                hostGrid = Hubble.CreatingGrid;
                hostGrid.OnCloudMessageReceived += HostGrid_OnCloudMessageReceived;
            }
        }

        private void HostGrid_OnCloudMessageReceived(Wormhole cloudSession)
        {
            string strMsgID = cloudSession.GetString("msgID");
            switch (strMsgID)
            {
                case "UserControl6_testButtonClickCallback":
                    string strVal = cloudSession.GetString("callbackval");
                    if (!string.IsNullOrEmpty(strVal))
                    {
                        MessageBox.Show(strVal + "  CloudMessage Process by UserControl1");
                        button1.Text = strVal+" Modify button text";
                    }
                    break;
            }
        }
    }
}
