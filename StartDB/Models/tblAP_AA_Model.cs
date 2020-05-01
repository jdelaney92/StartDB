using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_AA_Model
    {
        public int AA_ID { get; set; }
        public int Gen_AA_ID { get; set; }
        public int AP_ID { get; set; }
        public string AA_Description { get; set; }
        public string Limitations { get; set; }
        public DateTime Last_update { get; set; }
        public string AA_Name { get; set; }
        public string Caveats { get; set; }
        public string AA_Title { get; set; }
    }
}