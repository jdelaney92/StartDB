using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_AN_Test_Model
    {
        public int Link_ID { get; set; }
        public int AN_ID { get; set; }
        public int Test_ID { get; set; }
        public int AP_ID { get; set; }
        public string Assigned_To { get; set; }
        public string Scope { get; set; }
    }
}