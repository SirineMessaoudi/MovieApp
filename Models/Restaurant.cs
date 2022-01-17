using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Restaurant :ServiceTouristique
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }

        public string typeCuisine { get; set; }
        
        public string FraicheurDePlats { get; set; }
    }
}
