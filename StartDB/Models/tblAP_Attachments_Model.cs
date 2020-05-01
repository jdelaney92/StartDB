using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_Attachments_Model
    {
        public int Link_ID { get; set; }
        public int AP_ID { get; set; }
        public int Attachment_ID { get; set; }
        public int Gen_AP_ID { get; set; }
    }
}