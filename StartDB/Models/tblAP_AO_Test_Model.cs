using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_AO_Test_Model
    {
        public int Link_ID { get; set; }
        public int AO_ID { get; set; }
        public int Test_ID { get; set; }
        public int AP_ID { get; set; }
        public string TO_Memo_Objectives { get; set; }
        public string TO_Memo_Description { get; set; }
        public short Allocation { get; set; }
    }
}