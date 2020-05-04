using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblCAC_ACS_Model
    {
        public int ID { get; set; }
        public int CAC_ID { get; set; }
        public string ACS_Num { get; set; } //ACS had # at the end?
        public string Description { get; set; }
        public int CAC_WB_ID { get; set; }
        public string ASO { get; set; }
        public string ASO_Original { get; set; }
    }
}