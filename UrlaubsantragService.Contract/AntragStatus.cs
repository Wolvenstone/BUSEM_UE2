namespace UrlaubsantragService.Contract {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public enum AntragStatus {
        [EnumMember]
        Offen = 0,
        [EnumMember]
        Genehmigt = 1,
        [EnumMember]
        Abgelehnt = 2
    }
}
