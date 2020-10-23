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

namespace SunnyForms2
{
    public partial class Form9 : Form
    {
        Grid hostGrid = null;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
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
