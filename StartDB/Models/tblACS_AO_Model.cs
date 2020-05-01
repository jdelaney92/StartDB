using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblACS_AO_Model
    {
        public int AO_ID { get; set; }
        public int ARID { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public string AONumber { get; set; }
        public int Level { get; set; }
        public int Parent_ID { get; set; }
        public int AP_AO_ID { get; set; }
        public int AP_AA_ID { get; set; }
        public int AP_ID { get; set; }
        public string AO_Title { get; set; }
        public int Gen_AO_ID { get; set; }
    }
}