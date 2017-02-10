using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Models;
using MovieGallery.Data;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        private MovieRepository _movieRepository = null;

        public MovieController()
        {
            _movieRepository = new MovieRepository();   
        }

        public ActionResult Index()
        {
            var movie = _movieRepository.GetMovies();

            return View(movie);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var movie = _movieRepository.GetMovie((int)id);

            return View(movie);
        }
    }
}