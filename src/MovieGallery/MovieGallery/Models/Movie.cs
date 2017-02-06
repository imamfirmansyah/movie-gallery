using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string YearsRelease { get; set; }
        public string StoryLineHtml { get; set; }
        public bool Favorite { get; set; }
        public string IssueNumber { get; set; }
        public Genre[] Genres { get; set; }

        public string DisplayText
        {
            get { return MovieTitle + " #" + IssueNumber; }
        }

        public string CoverMovieFileName
        {
            get { return MovieTitle.Replace(" ", "-").ToLower() + ".jpg"; }
        }
    }
}