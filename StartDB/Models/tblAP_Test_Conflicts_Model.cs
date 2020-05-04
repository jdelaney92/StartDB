using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_Test_Conflicts_Model
    {
        public int Conflict_ID { get; set; }
        public int Item_ID { get; set; }
        public string Item_Type { get; set; }
        public int Test_ID { get; set; }
        public string Change_Type { get; set; }
    }
}