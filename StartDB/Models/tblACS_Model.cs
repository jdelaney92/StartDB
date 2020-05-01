using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblACS_Model
    {
        public int ARID { get; set; }
        public string ACS_Description { get; set; } 
        public string ACS_Number { get; set; } 
        public string ACS_Version { get; set; } 
        public string Decisions { get; set; } 
        public string ARAOR { get; set; } 
        public string BMDS_Configuration { get; set; } 
        public DateTime LastUpdated { get; set; }
        public DateTime ImportDate { get; set; }
        public string SDD_Capability_Description { get; set; } 
        public string Additional_Capability { get; set; } 
        public string Assessment_Approach { get; set; }
        public string ImportUser { get; set; } 
        public string Comment { get; set; } 
        public int Status { get; set; }
        public string Owner { get; set; } 
        public int Latest { get; set; }
        public string Notes { get; set; } 
        public int Gen_ARID { get; set; } 
        public string Classification { get; set; }
        public string Class_By { get; set; }
        public string Class_Source { get; set; }
        public DateTime Declass { get; set; }
    }
}