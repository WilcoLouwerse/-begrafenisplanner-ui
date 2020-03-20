using System;

namespace begrafenisplanner.Models
{
    public class Grave
    {
        public int id { get; set; }
        public string reference { get; set; }
        public string cemetery { get; set; }
        public string location { get; set; }
        public string position { get; set; }
        public string graveType { get; set; }
        public string status { get; set; }
        public string acquisition { get; set; }
        public GraveCover graveCover { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
    }
}
