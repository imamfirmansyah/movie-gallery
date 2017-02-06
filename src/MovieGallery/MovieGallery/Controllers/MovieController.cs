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
            var movie = new Movie()
            {
                MovieTitle = "Wreck-It Ralph",
                YearsRelease = "2012",
                StoryLineHtml = "<p>Wreck-It Ralph longs to be as beloved as his game's perfect Good Guy, Fix-It Felix. Problem is, nobody loves a Bad Guy. But they do love heroes... so when a modern, first-person shooter game arrives featuring tough-as-nails Sergeant Calhoun, Ralph sees it as his ticket to heroism and happiness. He sneaks into the game with a simple plan -- win a medal -- but soon wrecks everything, and accidentally unleashes a deadly enemy that threatens every game in the arcade. Ralph's only hope? Vanellope von Schweetz, a young troublemaking &quot;glitch&quot; from a candy-coated cart racing game who might just be the one to teach Ralph what it means to be a Good Guy. But will he realize he is good enough to become a hero before it's &quot;Game Over&quot; for the entire arcade?.</p>",
                Favorite = true,
                IssueNumber = "21",
                Genres = new Genre[]
                {
                    new Genre() { Name = "Animation" },
                    new Genre() { Name = "Adventure" },
                    new Genre() { Name = "Comedy" },
                    new Genre() { Name = "Family" },
                    new Genre() { Name = "Sci-Fi" },
                }
            };

            return View(movie);
        }
    }
}