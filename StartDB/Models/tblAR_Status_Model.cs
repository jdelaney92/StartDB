using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAR_Status_Model
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string Status_title { get; set; }
        public string Status_descrption { get; set; }
        public string Email_notice { get; set; }
    }
}