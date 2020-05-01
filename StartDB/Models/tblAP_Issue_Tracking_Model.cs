using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_Issue_Tracking_Model
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Title { get; set; }
        public string POC { get; set; }
        public DateTime Date_Entered { get; set; }
        public string User_Name { get; set; }
        public string Source { get; set; }
        public string Impact { get; set; }
        public int Closed { get; set; }
        public string Mitigation { get; set; }
    }
}