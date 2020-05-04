using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblCAC_KTP_Conditions_Model
    {
        public int KC_ID { get; set; }
        public int KTP_ID { get; set; }
        public string Condition { get; set; }
        public string Value_Range { get; set; }
        public string Grouping { get; set; }
        public string Grouping_Classification { get; set; }
        public string Value_Range_Classification { get; set; }
        public string Units { get; set; }
        public int CAC_WB_ID { get; set; }
    }
}