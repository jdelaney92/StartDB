using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_Model
    {
        public int AP_ID { get; set; }
        public int Gen_AP_ID { get; set; }
        public string Decision_Name { get; set; }
        public int AP_Version { get; set; }
        public DateTime Decision_Date { get; set; }
        public string Owner_group { get; set; }
        public string Decision_Type { get; set; }
        public string Status { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Last_Update { get; set; }
        public string Decision_Description { get; set; }
        public string Classification { get; set; }
        public string Class_Source { get; set; }
        public string Class_By { get; set; }
        public DateTime Declass { get; set; }
        public string Increment { get; set; }
        public int Latest { get; set; }
        public int Baselined { get; set; }
        public string Created_By { get; set; }
        public string Assessment_Approach { get; set; }
        public int Archived { get; set; }
        public string AP_Limitations { get; set; }
        public string AP_Caveats { get; set; }
    }
}