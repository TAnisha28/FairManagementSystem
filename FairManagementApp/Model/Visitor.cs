using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementApp.Model
{
    class Visitor
    {
        public int visitorId { set; get; }
        public string name {  set; get; }
        public string email {  set; get; }
        public string contact {  set; get; }

        public int totalVisitor { set; get; }
    }
}
