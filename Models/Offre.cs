using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Offre
    {
        public int Id { get; set; }
        public int NbrePersonne { get; set; }
        public float Prix { get; set; }
        public string Descriptif { get; set; }
        public ICollection<ServiceTouristique> services { get; set; }
    }
}
