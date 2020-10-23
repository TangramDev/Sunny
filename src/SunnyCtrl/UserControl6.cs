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
    public partial class UserControl6 : UserControl
    {
        private Grid thisGrid = null;
        public UserControl6()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            thisGrid = Hubble.CreatingGrid;
            thisGrid.OnCloudMessageReceived += ThisGrid_OnCloudMessageReceived;
        }

        private void ThisGrid_OnCloudMessageReceived(Wormhole cloudSession)
        {
            string strMsgID = cloudSession.GetString("msgID");
            switch (strMsgID)
            {
                case "UserControl6_testButtonClickCallback":
                    string strVal = cloudSession.GetString("callbackval");
                    if (!string.IsNullOrEmpty(strVal))
                    {
                        MessageBox.Show(strVal + " CloudMessage Process by UserControl6");
                        button1.Text = strVal;
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thisGrid != null)
            {
                thisGrid.Wormhole.InsertString("msgID", "UserControl6_testButton1_click");
                thisGrid.Wormhole.InsertString("testVal", "this is a test for Usercontrol");
                thisGrid.Wormhole.SendMessage();
            }
        }
    }
}
