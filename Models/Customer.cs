using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Membershiptype membershiptype { get; set; }
        //1..1 obligatoire (clé étrangère obligatoire) :
        public int membershiptypeId { get; set; }
        public ICollection<Movie> movies { get; set; }
        public DateTime? DoB { get; set; }
    }
}