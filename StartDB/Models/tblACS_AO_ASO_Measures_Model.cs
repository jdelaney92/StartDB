using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblACS_AO_ASO_Measures_Model
    {
        public int AO_M_ID { get; set; }
        public int AO_ID { get; set; }
        public int ASO_ID { get; set; }
        public int ARID { get; set; }
        public string Measures { get; set; }
        public string FullDescription { get; set; }
        public int AP_AN_ID { get; set; }
        public int AP_AO_ID { get; set; }
        public int AP_ID { get; set; }
        public int Gen_AO_M_ID { get; set; }
    }
}