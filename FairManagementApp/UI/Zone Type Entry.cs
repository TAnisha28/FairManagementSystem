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
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.UI
{
    public partial class Zone_Type_Entry : Form
    {
        public Zone_Type_Entry()
        {
            aZones.Clear();
            InitializeComponent();
            LoadZone();
        }
        ZoneEntryManager zoneEntryManager=new ZoneEntryManager();
        List<Zone> aZones = new List<Zone>(); 
        Zone aZone=new Zone();
        
        private void buttonSaveZone_Click(object sender, EventArgs e)
        {
            aZones.Clear();
            aZone.zoneName = textBoxZoneType.Text;
            MessageBox.Show(zoneEntryManager.SaveZone(aZone));
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
            listViewZoneType.Items.Clear();
            foreach (var zone in aZones)
            {
                ListViewItem item = new ListViewItem(zone.zoneName.ToString());
                //item.SubItems.Add(zone.);

                item.Tag = zone;
                listViewZoneType.Items.Add(item);
            }
        }

    }
}
