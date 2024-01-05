using Microsoft.AspNetCore.Identity;
using MVC_movie_app.Areas.Identity.Data;
using MVC_movie_app.Controllers;

namespace MVC_movie_app.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public MVC_movie_appUser User { get; set; }
        public String Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public String Genre { get; set; }
        public int Price { get; set; }
    }
}
