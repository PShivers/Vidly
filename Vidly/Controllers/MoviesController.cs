using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ViewResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            
            return View(movie);
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