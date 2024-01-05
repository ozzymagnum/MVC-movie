using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_movie_app.Models;

namespace MVC_movie_app.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MVC_movie_appUser class
public class MVC_movie_appUser : IdentityUser
{
    public List<Movie> Movies { get; set; }
}

