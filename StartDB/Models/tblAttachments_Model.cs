using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartDB.Models
{
    public class tblAttachments_Model
    {
        public int ID { get; set; }
        public byte Blob { get; set; } //is this the right conversion?
        public string Source_Table { get; set; }
        public int SourceID { get; set; }
    }
}