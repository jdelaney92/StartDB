using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblCAC_KTP_Model
    {
        public int KTP_ID { get; set; }
        public int CAC_ID { get; set; }
        public string Ktp_Num { get; set; } //Ktp#
        public string Priority { get; set; }
        public string Venue { get; set; }
        public string Description_Classification { get; set; }
        public string Descrption { get; set; }
        public int CAC_WB_ID { get; set; }
        public string Configuration_Note { get; set; }
        public string Venue_Notes { get; set; }
        public int KTP_Version { get; set; }
        public int Latest { get; set; }
        public string ACS_AO { get; set; }
        public string ACS_AO_Original { get; set; }
        public string Priority_Rank { get; set; }
    }
}