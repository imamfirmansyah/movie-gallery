using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Models;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Detail()
        {
            var movieGallery = new Movie()
            {
                MovieTitle = "Big Hero 6",
                YearsRelease = "2014",
                StoryLineHtml = "<p>When a devastating event befalls the city of San Fransokyo and catapults " +
                            "Hiro into the midst of danger, he turns to Baymax and his close friends " +
                            "adrenaline junkie Go Go Tomago, neatnik Wasabi, chemistry whiz Honey Lemon " +
                            "and fanboy Fred. Determined to uncover the mystery, Hiro transforms his " +
                            "friends into a band of high-tech heroes called &quot;Big Hero 6&quot;.</p>",
                Favorite = true,
                IssueNumber = "20",
                Genres = new Genre[]
                {
                    new Genre() { Name = "Animation" },
                    new Genre() { Name = "Action" },
                    new Genre() { Name = "Adventure" },
                    new Genre() { Name = "Comedy" },
                    new Genre() { Name = "Drama" },
                    new Genre() { Name = "Family" },
                    new Genre() { Name = "Sci-Fi" },
                }

            };

            return View(movieGallery);
        }
    }
}