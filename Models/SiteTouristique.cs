using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class SiteTouristique : ServiceTouristique
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Anciennete { get; set; }
        public ICollection<Activite> activites { get; set; }
        public Bus bus { get; set; }
        
       public Restaurant restaurant { get; set; }
       
    }
}
