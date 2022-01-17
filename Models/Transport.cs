using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Transport:ServiceTouristique
    {
        public int Id { get; set; }
        public ICollection<Bus> buses { get; set; }
    }
}
