using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class ServiceTouristique
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Localisation localisation { get; set; }
        public int LocalisationId { get; set; }
        public ICollection<Offre> offres { get; set; }
        

    }
}
