using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models.MVVM
{
    public class CustomerMovieVM
     {
        public Movie movie { get; set; }

        public List<Customer> customers { get; set; }
    }
}