using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.MovieTitle = "Big Hero 6";
            ViewBag.YearsRelease = "2014";
            ViewBag.StoryLine = "<p>When a devastating event befalls the city of San Fransokyo and catapults " +
                            "Hiro into the midst of danger, he turns to Baymax and his close friends " +
                            "adrenaline junkie Go Go Tomago, neatnik Wasabi, chemistry whiz Honey Lemon " +
                            "and fanboy Fred. Determined to uncover the mystery, Hiro transforms his " +
                            "friends into a band of high-tech heroes called &quot;Big Hero 6&quot;.</p>";
            ViewBag.Genres = new string[]
            {
                "Animation",
                "Action",
                "Adventure",
                "Comedy",
                "Drama",
                "Family",
                "Sci-Fi"
            };

            return View();
        }
    }
}