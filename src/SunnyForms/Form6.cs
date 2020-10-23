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
    public partial class Form6 : Form
    {
        Grid thisGrid = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            thisGrid = Hubble.CreatingGrid;
            thisGrid.OnCloudMessageReceived += ThisGrid_OnCloudMessageReceived;
        }

        private void ThisGrid_OnCloudMessageReceived(Wormhole cloudSession)
        {
        }
    }
}
