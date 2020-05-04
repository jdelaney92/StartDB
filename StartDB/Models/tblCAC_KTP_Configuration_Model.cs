using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblCAC_KTP_Configuration_Model
    {
        public int ID { get; set; }
        public int KTP_ID { get; set; }
        public string Component { get; set; }
        public string Build { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
        public int CAC_WB_ID { get; set; }
    }
}