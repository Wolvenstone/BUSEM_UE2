using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Urlaubsantrag.BOs {
    public class Urlaubsantrag {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public DateTime Urlaubsbeginn { get; set; }

        public DateTime Urlaubsende { get; set; }
    }
}