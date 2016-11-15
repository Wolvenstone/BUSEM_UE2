using System;
using System.Runtime.Serialization;

namespace UrlaubsantragService.Contract {
    /// <summary>
    /// Interface that describes a class.
    /// </summary>
    public interface IAntwort {
        string Grund { get; set; }
    }
}