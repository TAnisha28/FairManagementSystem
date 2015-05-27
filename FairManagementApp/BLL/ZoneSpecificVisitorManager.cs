using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ZoneSpecificVisitorManager
    {
      
        ZoneSpecificVisitorGateway aZoneSpecificVisitorGateway=new ZoneSpecificVisitorGateway();
             public List<Visitor> GetAllVisitors(int aZone)
        {
            return aZoneSpecificVisitorGateway.GetAllVisitors(aZone);
        }
    }
}
