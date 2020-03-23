using System;
using System.Collections.Generic;

namespace begrafenisplanner.Models
{
    public class Grave
    {
        public int id { get; set; }
        public List<GraveCover> graveCovers { get; set; }
        public string reference { get; set; }
        public string cemetery { get; set; }
        public string deceased { get; set; }
        public string location { get; set; }
        public int position { get; set; }
        public string graveType { get; set; }
        
        public string status { get; set; }
        public string acquisition { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
    }
}
