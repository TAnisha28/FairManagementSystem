using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.UI;

namespace FairManagementApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Entry visitorEntry=new Visitor_Entry();
            visitorEntry.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zone_Type_Entry zoneTypeEntry=new Zone_Type_Entry();
            zoneTypeEntry.Show();
        }

        private void zoneSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zone_Specific_Visitor_Information_Report zoneSpecificVisitor =new Zone_Specific_Visitor_Information_Report();
            zoneSpecificVisitor.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zone_Type_Wise_Visitor_Number_Report zoneTypeWiseVisitor=new Zone_Type_Wise_Visitor_Number_Report();
            zoneTypeWiseVisitor.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
