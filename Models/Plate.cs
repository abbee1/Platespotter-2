using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateSpotter.Models {
    public class Plate {
        public int Id { get; set; }
        public string FoundByUserId { get; set; }
        public int PlateNr { get; set; }
        public string PlateLetter { get; set; }
        public string Date { get; set; }
        public string GeoGoogle { get; set; }
        public string Description { get; set; }
    }
}