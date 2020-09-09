using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUPicksList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BuildingList.DataSource = Properties.Settings.Default.BUList;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
