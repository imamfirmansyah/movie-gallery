using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieGallery.Models;

namespace MovieGallery.Data
{
    public class MovieRepository
    {
        private static Movie[] _movieGalleries = new Movie[]
        {
            new Movie()
            {
                Id = 1,
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
            },

            new Movie()
            {
                Id = 2,
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
            },

            new Movie()
            {
                Id = 3,
                MovieTitle = "Despicable Me",
                YearsRelease = "2010",
                StoryLineHtml = "<p>In a happy suburban neighborhood surrounded by white picket fences with flowering rose bushes, sits a black house with a dead lawn. Unbeknownst to the neighbors, hidden beneath this home is a vast secret hideout. Surrounded by a small army of minions, we discover Gru, planning the biggest heist in the history of the world. He is going to steal the moon. (Yes, the moon!) Gru delights in all things wicked. Armed with his arsenal of shrink rays, freeze rays, and battle-ready vehicles for land and air, he vanquishes all who stand in his way. Until the day he encounters the immense will of three little orphaned girls who look at him and see something that no one else has ever seen: a potential Dad. The world's greatest villain has just met his greatest challenge: three little girls named Margo, Edith and Agnes.</p>",
                Favorite = true,
                IssueNumber = "20",
                Genres = new Genre[]
                {
                    new Genre() { Name = "Animation" },
                    new Genre() { Name = "Adventure" },
                    new Genre() { Name = "Comedy" },
                    new Genre() { Name = "Family" },
                }
            }
        };

        public Movie[] GetMovies()
        {
            return _movieGalleries;
        }

        public Movie GetMovie(int id)
        {
            Movie movieToReturn = null;

            foreach (var movie in _movieGalleries)
            {
                if (movie.Id == id)
                {
                    movieToReturn = movie;
                    break;
                }    
            }

            return movieToReturn;
        }
    }
}