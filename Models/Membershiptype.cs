using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Membershiptype
    {
        public int Id { get; set; }
        public int SignUpFee { get; set; }
        public int DurationMonth { get; set; }
        public int DiscountRate { get; set; }
    }
}