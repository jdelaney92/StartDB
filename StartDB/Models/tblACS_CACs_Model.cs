using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblACS_CACs_Model
    {
        public int ID { get; set; }
        public int ARID { get; set; }
        public string CAC_Number { get; set; }
        public string CAC_Title { get; set; }
        public string CAC_Description { get; set; }
    }
}