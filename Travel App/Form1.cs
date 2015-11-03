using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkBoxWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWest.Checked == true)
            {
                // add this region to the region traveled. 
            }

        }

        private void checkBoxMidwest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMidwest.Checked == true)
            {
                // add this region to the list 
            }
        }

        private void checkBoxEastCoast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEastCoast.Checked == true)
            {

            }
        }

    }
}
