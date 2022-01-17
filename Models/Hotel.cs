using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Hotel :ServiceTouristique
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int NombreEtoile { get; set; }

        public ICollection<Chambre> chambres { get; set; }
        public string Qualite { get; set; }
        public Bus bus { get; set; }
      
       public Restaurant restaurant { get; set; }
       


    }
}
