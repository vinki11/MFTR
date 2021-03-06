//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetMFTR.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Communication
    {
        public int Communication_ID { get; set; }
        public string Dossier_ID { get; set; }
        public string Adulte_ID { get; set; }
        public string Referent_ID { get; set; }
        public Nullable<System.DateTime> DateEven { get; set; }
        public Nullable<System.DateTime> DateComm { get; set; }
        public Nullable<System.TimeSpan> Heure { get; set; }
        public string Type { get; set; }
        public string Motif { get; set; }
        public string Interlocuteur { get; set; }
        public string Note { get; set; }
        public string Intervenant { get; set; }
        public string Temp_interlocuteur { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public Nullable<int> IdIntervenant { get; set; }
    
        public virtual Dossier Dossier { get; set; }
        public virtual Intervenant Intervenant1 { get; set; }
    }
}
