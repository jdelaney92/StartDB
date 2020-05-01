using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class TblAP_Standard_AN_Model
    {
        public int Standard_AN_ID { get; set; }
        public int Standard_Number { get; set; }
        public string Standard_Title { get; set; }
        public string Standard_Description { get; set; }
        public string Standard_Intent { get; set; }
        public int Standard_Revision { get; set; }
        public int Latest { get; set; }
        public int Approved { get; set; }
        public string Standard_Note { get; set; }
        public string Standard_Images { get; set; }
        public string Created_By { get; set; }
    }
}