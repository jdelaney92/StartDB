using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_AA_AO_AN_Model
    {
        public int AN_ID { get; set; }
        public int Gen_AN_ID { get; set; }
        public int AP_ID { get; set; }
        public int AA_ID { get; set; }
        public int AO_ID { get; set; }
        public string Description { get; set; }
        public string Rationale { get; set; }
        public string Group { get; set; }
        public string Example_Images { get; set; }
        public string AN_Name { get; set; }
        public string Author_Note { get; set; }
        public string AN_Title { get; set; }
        public int Standard_AN_ID { get; set; }
        public int Standard_AN_Number { get; set; }

 
    }
}