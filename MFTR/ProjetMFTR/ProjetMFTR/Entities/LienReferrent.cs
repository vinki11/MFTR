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
    
    public partial class LienReferrent
    {
        public int Lien_ID { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public string Referent_ID { get; set; }
        public string Notes { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual Parent Parent { get; set; }
        public virtual Referent Referent { get; set; }
    }
}
