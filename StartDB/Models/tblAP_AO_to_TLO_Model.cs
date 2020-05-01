using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_AO_to_TLO_Model
    {
        public int Link_ID { get; set; }
        public int AO_ID { get; set; }
        public int Question_ID { get; set; }
        public int Consideration_ID { get; set; }
        public int AP_ID { get; set; }
        public int IMAP_Version_ID { get; set; }
    }
}