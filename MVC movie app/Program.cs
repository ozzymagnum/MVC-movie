using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using MVC_movie_app.Areas.Identity.Data;
using MVC_movie_app.Controllers;
using MVC_movie_app.Data;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); /*?? throw new InvalidOperationException("Connection string 'MVC_movie_appContextConnection' not found. ");*/

        builder.Services.AddDbContext<MVC_movie_appContext>(options =>
            options.UseSqlServer(connectionString));



        builder.Services.AddDefaultIdentity<MVC_movie_appUser>(options => options.SignIn.RequireConfirmedAccount = false)
         .AddRoles<IdentityRole>()
         .AddEntityFrameworkStores<MVC_movie_appContext>();



        builder.Services.AddRazorPages();
        builder.Services.AddLogging();

        builder.Services.Configure<IdentityOptions>(options =>
        {
            // Default Password settings.
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
            options.Password.RequiredUniqueChars = 0;
        });



        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            //app.UseMigrationsEndPoint();
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();

        }


        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

        

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
        });
        app.MapRazorPages();

        app.Run();
    }
}