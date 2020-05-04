using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAXP_AN_Status_Model
    {
        public int Link_ID { get; set; }
        public int AXP_ID { get; set; }
        public int AN_ID { get; set; }
        public int Test_ID { get; set; }
        public int AP_ID { get; set; }
        public string EET_Status { get; set; }
        public string Comment { get; set; }
        public string Initial_Change_Type { get; set; }
        public string Change_Type { get; set; }
        public string AXP_Assigned_To { get; set; }
        public string Initial_Assigned_To { get; set; }
        public string MDR_Status { get; set; }
        public string MDR_Reference { get; set; }
        public int Approved_FollowUp { get; set; }
        public string MDR_Status_Comment { get; set; }
        public int Early_Analysis { get; set; }
        public string ATL_MDR_Status { get; set; }
        public string Statused_By { get; set; }
        public int Standard_AN_ID { get; set; }
        public int Standard_AN_Number { get; set; }
        public DateTime Early_Date { get; set; }
    }
}