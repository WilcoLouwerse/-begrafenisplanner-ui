using System;
using System.Collections.Generic;

namespace begrafenisplanner.Models
{
    public class GraveCover
    {
        public int id { get; set; }
        public List<Grave> graves { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
    }
}
