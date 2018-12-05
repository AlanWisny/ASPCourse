using ASPCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPCourse.ViewModels;


namespace ASPCourse.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var Movies = GetMovies();
            return View(Movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){ Id = 1, Name = "Shrek"},
                new Movie(){ Id = 2, Name = "AdeWall-e"}
            };
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
 

        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek" };
            var movie1 = new Movie(){ Name = "Wall-E"};
            var customers = new List<Customer>
            {
                new Customer { Name = "customer 1"},
                new Customer { Name = "customer 2"},
                new Customer { Name = "Mary Williams"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}