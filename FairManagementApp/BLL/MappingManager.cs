using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;

namespace FairManagementApp.BLL
{
    class MappingManager
    {
        MappingGateway aMappingGateway=new MappingGateway();
        public void InsertIntoMapTable(int idZone, int idVisitor)
        {
            aMappingGateway.InsertIntoMapTable(idZone,idVisitor);
        }
    }
}
