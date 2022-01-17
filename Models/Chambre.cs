using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Chambre
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Type { get; set; }
        public float Prix { get; set; }
        public Hotel hotel { get; set; }

    }
}
