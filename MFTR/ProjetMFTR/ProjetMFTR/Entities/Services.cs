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
    
    public partial class Services
    {
        public int Service_ID { get; set; }
        public string Dossier_ID { get; set; }
        public string Nom { get; set; }
        public string Frequence { get; set; }
        public string Journee { get; set; }
        public string Duree { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual Dossier Dossier { get; set; }
    }
}