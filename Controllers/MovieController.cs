using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [Route("Movie/List")]
        public ActionResult Index()
        {   //un seul movie : 
            Movie movie = new Movie()
            {
                Name = "Titanic",
            };
            //return View(movie);

            //une liste de movies : 
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name ="Movie 2 "},
                new Movie{Name ="Movie 3 "},
            };
            return View(movies);
        }

        // MODIFIER :Movie 
        //localhost:44346/Movie/Edit/1
        public ActionResult Edit(int Id)
        {
            return Content("MovieId" + Id);

        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult byRelease(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}
