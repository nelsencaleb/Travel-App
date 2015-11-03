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

        public bool checkDate(DateTime leave, DateTime go)
        {
            if (leave.CompareTo(DateTime.Now.AddDays(-1)) == -1)
            {
                MessageBox.Show("Leave date must be no ealier then today.");
                return false;
            }
            else if (go.CompareTo(leave) == -1)
            {
                MessageBox.Show("Return date must be after leave date.");
                return false;
            }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                checkDate(dateTimePicker1.Value, dateTimePicker2.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("nope");
            }
        }
    }
}
