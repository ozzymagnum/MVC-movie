using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_movie_app.Areas.Identity.Data;
using MVC_movie_app.Models;

namespace MVC_movie_app.Data
{
    public class MVC_movie_appContext : IdentityDbContext<MVC_movie_appUser>
    {
        public MVC_movie_appContext(DbContextOptions<MVC_movie_appContext> options)
            : base(options)
        {
        }

        // DbSet for your Movie entity
        public DbSet<MVC_movie_app.Models.Movie>? Movie { get; set; }

        // No need to use Set method for IdentityUser
        // The Users property is already inherited from IdentityDbContext
        // If you want to access users, use DbSet<MVC_movie_appUser>
        // public new DbSet<MVC_movie_appUser> Users { get; set; }
    }
}

