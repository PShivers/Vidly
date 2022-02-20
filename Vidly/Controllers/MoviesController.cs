using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            var movies = new List<Movie>
            {
                new Movie() {Name = "Shrek", Id = 1},
                new Movie() {Name = "Shrek 2", Id = 2},
                new Movie() {Name = "Shrek the Third", Id = 3},
            };

            return View(movies);
        }
        public ActionResult Details(int? movieId)
        {
            var movies = new List<Movie>
            {
                new Movie() {Name = "Shrek", Id = 1},
                new Movie() {Name = "Shrek 2", Id = 2},
                new Movie() {Name = "Shrek the Third", Id = 3},
            };

            var movie = movies.Find(c => c.Id == movieId);

            return View(movie);
        }

        public ViewResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Id = 1},
                new Customer {Name = "Customer 2", Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };

            return View(viewModel);
        }

        //todo: figure out how mosh used resharper to rename the parameter and any references to it. he said F2 but it didn't work for me
        public ActionResult Edit(int movieId)
        {
            return Content("movieId = " + movieId);
        }


        // Attribute Routing
        // You first need to enable this in "RouteConfig.cs".
        // Then I can specify custom routes for this controller method and if i want i can add
        // constraints. The constraints are the part of the string after the colon.
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}