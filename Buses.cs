//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buses()
        {
            this.ServiceTouristiques1 = new HashSet<ServiceTouristiques>();
            this.ServiceTouristiques2 = new HashSet<ServiceTouristiques>();
        }
    
        public int Id { get; set; }
        public int NumeroLigne { get; set; }
        public Nullable<System.DateTime> Horaire { get; set; }
        public Nullable<int> Transport_Id { get; set; }
    
        public virtual ServiceTouristiques ServiceTouristiques { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTouristiques> ServiceTouristiques1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTouristiques> ServiceTouristiques2 { get; set; }
    }
}
