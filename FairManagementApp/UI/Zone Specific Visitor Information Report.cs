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
    public partial class Zone_Specific_Visitor_Information_Report : Form
    {
        public Zone_Specific_Visitor_Information_Report()
        {
            InitializeComponent();
        }
        ZoneEntryManager zoneEntryManager=new ZoneEntryManager();
        ZoneSpecificVisitorManager aZoneSpecificVisitorManager = new ZoneSpecificVisitorManager();
        List<Zone> aZones=new List<Zone>();
        List<Visitor> aVisitors=new List<Visitor>(); 
       
        public void LoadAllZoneInComboBox(List<Zone> aZone)
        {
            aVisitors.Clear();
            comboBoxZoneSelect.Items.Clear();
            comboBoxZoneSelect.DisplayMember = "ZoneName";
            comboBoxZoneSelect.ValueMember = "ZoneId";
            comboBoxZoneSelect.DataSource = null;
            comboBoxZoneSelect.DataSource = aZone;
            comboBoxZoneSelect.EndUpdate();
        }
        private void comboBoxZoneSelect_Click(object sender, EventArgs e)
        {
            comboBoxZoneSelect.DataSource = null;
            aZones = null;
            aZones = zoneEntryManager.GetAllZones();
            LoadAllZoneInComboBox(aZones);
        }
        Zone zone = new Zone();
        private void buttonShowVisitor_Click(object sender, EventArgs e)
        {
           
            zone.zoneId = int.Parse(comboBoxZoneSelect.SelectedValue.ToString()); ;
            LoadVisitor(zone.zoneId);
        }
        private void LoadVisitor(int aZone)
        {
            aVisitors.Clear();
            aVisitors = aZoneSpecificVisitorManager.GetAllVisitors(aZone);
            LoadListViewByVisitors(aVisitors);

        }
        Visitor aVisitor = new Visitor();
        private void LoadListViewByVisitors(List<Visitor> aVisitors)
        {
            // show students to list view 
          
            listViewZoneSpecific.Items.Clear();
            int count = 0;
            foreach (var visitor in aVisitors)
            {
                count++;
                ListViewItem item = new ListViewItem(visitor.name.ToString());
                item.SubItems.Add(visitor.email.ToString());
                item.SubItems.Add(visitor.contact.ToString());
                 aVisitor.totalVisitor = count;
               
                item.Tag = visitor;
                listViewZoneSpecific.Items.Add(item);

            }
            textBoxTotalVisitorPerZone.Text = Convert.ToString(aVisitor.totalVisitor);
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 1;

            int j = 1;

            foreach (ListViewItem comp in listViewZoneSpecific.Items)
            {

                ws.Cells[i, j] = comp.Text.ToString();

                //MessageBox.Show(comp.Text.ToString());

                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {

                    ws.Cells[i, j] = drv.Text.ToString();

                    j++;

                }

                j = 1;

                i++;

            }
        }
      
    }
}
