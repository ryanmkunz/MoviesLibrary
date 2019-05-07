﻿using MovieLibrary.Models;
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
        public Movie Get(int id)
        {
            var movie = context.Movies.FirstOrDefault(m => m.id == id);
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
            if (!ModelState.IsValid)
            {
                BadRequest("Invalid data.");
            }
            else
            {
                var currentMovie = context.Movies.Find(id);
                if (currentMovie == null)
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }
                else
                {
                    currentMovie.title = movie.title;
                    currentMovie.genre = movie.genre;
                    currentMovie.director = movie.director;
                }
            }            
        }
    }
}
