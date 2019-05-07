using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieLibrary.Controllers
{
    public class MoviesController : ApiController
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET api/values
        public IEnumerable<Movie> Get()
        {
            var movies = context.Movies.ToList();
            return movies;
        }

        // GET api/values/5
        public string Get(int id)
        {
            var movie = context.Movies.FirstOrDefault(m => m.id == id).title.ToString();
            return movie;
        }

        // POST api/values
        public void Post([FromBody]Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }
        
        // PUT api/values/5
        public void Put(int id, [FromBody]Movie movie)
        {
            if (context.Movies.Find(id) == null)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
            }
            else
            {
                
            }
        }
    }
}
