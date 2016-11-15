using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UrlaubsantragService.Contract {
    [DataContract]
    [Serializable]
    public class Genehmigung : IAntwort {

        /// <summary>
        /// Gets or sets the value for Grund property.
        /// </summary>
        [DataMember]
        public string Grund { get; set; }
    }
}