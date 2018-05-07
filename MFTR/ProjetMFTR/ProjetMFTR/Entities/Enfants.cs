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
    
    public partial class Enfants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enfants()
        {
            this.Suivi = new HashSet<Suivi>();
        }
    
        public int Enfant_ID { get; set; }
        public string Dossier_ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public Nullable<System.DateTime> Naissance { get; set; }
        public Nullable<bool> Accueil { get; set; }
        public string Notes { get; set; }
        public string Referent_ID { get; set; }
        public string Photo { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
				public string Name { get { return Nom + ", " + Prenom; } }
    
        public virtual Dossier Dossier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suivi> Suivi { get; set; }
    }
}
