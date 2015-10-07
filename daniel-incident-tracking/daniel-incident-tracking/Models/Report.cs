using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daniel_incident_tracking.Models
{
    public class Report
    {
        public string name { get; set; }
        public string location { get; set; }
        public string incident { get; set; }
        public string witness { get; set; }
        public string date { get; set; }
        public string supervisor { get; set; }

        //Gina
        public string contribFactor { get; set; }

        public string notifName { get; set; }

        public string victimName { get; set; }

    }
}