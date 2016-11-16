using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace UrlaubsantragService.Contract {
    [KnownTypeAttribute(typeof(AntragStatus))]
    [DataContract]
    public class Urlaubsantrag {
        [DataMember]
        public string Vorname { get; set; }

        [DataMember]
        public string Nachname { get; set; }

        [DataMember]
        public DateTime Urlaubsbeginn { get; set; }

        [DataMember]
        public DateTime Urlaubsende { get; set; }

        [DataMember]
        public AntragStatus Status { get; set; }
    }
}