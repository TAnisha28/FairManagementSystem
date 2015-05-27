using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class VisitorEntryManager
    {
        VisitorEntryGateway aVisitorEntryGateway=new VisitorEntryGateway();
        public string SaveVisitor(Visitor aVisitor)
        {
            bool IsEmailExist = aVisitorEntryGateway.IsEmailExist(aVisitor.email);
            if (!IsEmailExist)
            {

                if (aVisitorEntryGateway.SaveVisitor(aVisitor) > 0)
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
                return "Email Exist";
            }
        }

        public int GetVisitorIdByEmail(string email)
        {
            return aVisitorEntryGateway.GetVisitorIdByEmail(email);
        }
    }
}
