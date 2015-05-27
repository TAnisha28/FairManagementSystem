using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;

namespace FairManagementApp.UI
{
    public partial class Zone_Type_Wise_Visitor_Number_Report : Form
    {
        public Zone_Type_Wise_Visitor_Number_Report()
        {
            InitializeComponent();
        }

        private ZoneEntryManager zoneEntryManager = new ZoneEntryManager();
        private List<Zone> aZones = new List<Zone>();
        private Zone aZone = new Zone();

        private void Zone_Type_Wise_Visitor_Number_Report_Load(object sender, EventArgs e)
        {
            LoadZone();
        }

        private void LoadZone()
        {
            aZones.Clear();
            aZones = zoneEntryManager.GetAllZones();
            LoadListViewByZone(aZones);

        }

        private void LoadListViewByZone(List<Zone> aZones)
        {
            // show students to list view 
            int total = 0;
            listViewZoneWiseVisitor.Items.Clear();
            foreach (var zone in aZones)
            {
                ListViewItem item = new ListViewItem(zone.zoneName.ToString());
                item.SubItems.Add(zone.zoneTotal.ToString());
                total = total+zone.zoneTotal;
                item.Tag = zone;
                listViewZoneWiseVisitor.Items.Add(item);

            }
            textBoxZoneWiseTotal.Text = Convert.ToString(total);
        }
    }
}
