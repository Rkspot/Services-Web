//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceWeb2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Nullable<int> Pv { get; set; }
        public Nullable<double> Force { get; set; }
        public Nullable<double> Dexterite { get; set; }
        public Nullable<double> Fuite { get; set; }
        public Nullable<int> xp { get; set; }
        public Nullable<int> po { get; set; }

        public PersonneDto toDto()
        {
            return new Mapping().toDto(this);
        }
    }

}
