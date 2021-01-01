﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universe;

namespace SunnyCtrl2
{
    public partial class UserControl8 : UserControl
    {
        Xobj hostXobj = null;
        public UserControl8()
        {
            InitializeComponent();
        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            if (Cosmos.CreatingXobj != null)
            {
                hostXobj = Cosmos.CreatingXobj;
                hostXobj.OnCloudMessageReceived += HostXobj_OnCloudMessageReceived;
            }
        }

        private void HostXobj_OnCloudMessageReceived(Wormhole cloudSession)
        {
        }
    }
}
