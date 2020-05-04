using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAXP_Versions_Model
    {
        public int AXP_ID { get; set; }
        public int Test_ID { get; set; }
        public int AXP_Version { get; set; }
        public string AXP_Description { get; set; }
        public DateTime Date_Created { get; set; }
        public string Created_By { get; set; }
        public string Classification { get; set; }
        public string Class_Source { get; set; }
        public string Class_By { get; set; }
        public DateTime Declass { get; set; }
        public string Excluded_APs { get; set; }
        public int Latest { get; set; }
        public int AXP_Locke { get; set; }
        public int PreTest_Locked { get; set; }
    }
}