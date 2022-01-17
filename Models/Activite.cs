using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Activite
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public float Prix { get; set; }
        public SiteTouristique site { get; set; }
    }
}
