using Movies1711.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Movies1711.Controllers
{

    //[EnableCors("*", "*", "*")] // Origin[url of request domain],  Header,  Method[get, post, put, delete]
    public class MoviesController : ApiController
    {
        private static List<Movie> movies = new List<Movie>();
        private static int counter = 0;
        static MoviesController()
        {
            movies.Add(new Movie { Id = 1, Name = "Hagiga Basnooker", Genre = "Boorekas", Rank = 5, Year = 1980 });
            movies.Add(new Movie { Id = 2, Name = "Wonder woman", Genre = "Fantasy", Rank = 5, Year = 2016 });
            movies.Add(new Movie { Id = 3, Name = "Joker", Genre = "Fantasy realistic", Rank = 6, Year = 2019 });
            movies.Add(new Movie { Id = 4, Name = "Terminator 5", Genre = "Fantasy", Rank = 2, Year = 2019 });
            movies.Add(new Movie { Id = 5, Name = "Battle of midway", Genre = "History action", Rank = 3, Year = 2019 });
            counter = movies.Count;
        }

        // GET api/messages
        public IHttpActionResult Get()
        {
            if (movies.Count == 0)
                return StatusCode(HttpStatusCode.NoContent);
            return Ok(movies);
        }

        [HttpGet]
        public IHttpActionResult Get([FromUri] int id)
        {
            Movie result = movies.FirstOrDefault(m => m.Id == id);
            if (result == null)
                return StatusCode(HttpStatusCode.NoContent);
            return Ok(result);
        }


        [HttpPost]
        // POST api/messages
        public IHttpActionResult Post([FromBody]Movie movie)
        {
            movie.Id = ++counter;
            movies.Add(movie);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPut]
        // PUT api/messages/5
        public IHttpActionResult Put(int id, [FromBody]Movie movie)
        {
            Movie result = movies.FirstOrDefault(m => m.Id == id);
            if (result != null)
            {
                result.Year = movie.Year;
                result.Genre = movie.Genre;
                result.Name = movie.Name;
                result.Rank = movie.Rank;
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Content(HttpStatusCode.NotFound, $"Movie with id {id} not found");
        }

        [HttpDelete]
        // DELETE api/messages/5
        public IHttpActionResult Delete(int id)
        {
            Movie result = movies.FirstOrDefault(m => m.Id == id);
            if (result != null)
            {
                movies.Remove(result);
                return StatusCode(HttpStatusCode.Accepted);
            }
            return Content(HttpStatusCode.NotFound, $"Movie with id {id} not found");

        }

    } 
}
