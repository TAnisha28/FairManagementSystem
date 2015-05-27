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
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FairManagementApp.UI
{
    public partial class Visitor_Entry : Form
    {
        public Visitor_Entry()
        {
            InitializeComponent();

        }
        Visitor aVisitor=new Visitor();
        VisitorEntryManager aVisitorEntryManager=new VisitorEntryManager();
        ZoneEntryManager zoneEntryManager = new ZoneEntryManager();
        MappingManager aMappingManager=new MappingManager();
        List<Zone> aZones = new List<Zone>();
        Zone aZone = new Zone();
        private void buttonSaveVisitor_Click(object sender, EventArgs e)
        {
            aVisitor.name=textBoxVisitorName.Text;
            aVisitor.email = textBoxEmail.Text;
            aVisitor.contact = textBoxContactNum.Text;
            List<Zone> aZonesList = new List<Zone>();
            MessageBox.Show(aVisitorEntryManager.SaveVisitor(aVisitor));
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                aZone.zoneName = itemChecked.ToString();
                aZonesList.Add(aZone);
                aZone.zoneId = zoneEntryManager.GetZoneIdByName(aZone.zoneName);
                aVisitor.visitorId = aVisitorEntryManager.GetVisitorIdByEmail(aVisitor.email);
                aMappingManager.InsertIntoMapTable(aZone.zoneId, aVisitor.visitorId);
            }
            Visitor_Entry_Load_1(sender,e);
            ClearTextBox();


        }

        public void ClearTextBox()
        {
            textBoxVisitorName.Clear();
            textBoxEmail.Clear();
            textBoxContactNum.Clear();
        }
        private void LoadListViewByZone(List<Zone> aZones)
        {
            
            checkedListBox1.Items.Clear();
            foreach (var zone in aZones)
            {
                checkedListBox1.Items.Add(zone.zoneName);
                //checkedListBox1.Items.Add("Monday", CheckState.Unchecked);
                //checkedListBox1.Items.Add("Tuesday", CheckState.Indeterminate);
                //checkedListBox1.Items.Add("Wednesday", CheckState.Checked);
                
            }
        }

        private void Visitor_Entry_Load_1(object sender, System.EventArgs e)
        {
            checkedListBox1.Items.Clear();
            aZones.Clear();
            aZones = zoneEntryManager.GetAllZones();
            LoadListViewByZone(aZones);

        }

    }
}
