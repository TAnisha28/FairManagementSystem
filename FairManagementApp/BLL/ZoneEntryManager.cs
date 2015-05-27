using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ZoneEntryManager
    {
        Zone aZone=new Zone();
        ZoneEntryGateway zoneEntryGateway=new ZoneEntryGateway();

        public string SaveZone(Zone aZone)
        {
            bool IsZoneExist = zoneEntryGateway.IsZoneExist(aZone.zoneName);
            if (!IsZoneExist)
            {

                if (zoneEntryGateway.SaveZone(aZone) > 0)
                {
                    return "Saved successfully";
                }
                else
                {
                    return "Save failed";
                }
            }
            else
            {
                return "Zone Exist";
            }
        }

        public List<Zone> GetAllZones()
        {
            return zoneEntryGateway.GetAllZones();
        }

        public int GetZoneIdByName(string zoneName)
        {
            return zoneEntryGateway.GetZoneIdByName(zoneName);
        }
    }
}
