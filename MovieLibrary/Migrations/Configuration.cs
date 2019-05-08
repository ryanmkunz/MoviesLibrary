namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieLibrary.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieLibrary.Models.ApplicationDbContext context)
        {
            context.Movies.AddOrUpdate(
            new Models.Movie { Title = "The Departed", Genre = "Drama", DirectorName = "Martin Scorsese" },
            new Models.Movie { Title = "The Dark Knight", Genre = "Drama", DirectorName = "Christopher Nolan" },
            new Models.Movie { Title = "Inception", Genre = "Drama", DirectorName = "Christopher Nolan" },
            new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", DirectorName = "David Gordon Green" },
            new Models.Movie { Title = "Die Hard", Genre = "Action", DirectorName = "John McTiernan" }
            );
        }
    }
}
