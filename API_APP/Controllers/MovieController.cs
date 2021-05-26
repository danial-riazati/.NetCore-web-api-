using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_APP.Models;
using API_APP.Services;
namespace API_APP.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            List<MovieModel> list = await new MovieService().GetMovieAsync();
            return list;
        }

        [HttpGet("{id}")]
        public async Task<List<MovieModel>> Get(string id)
        {
            List<MovieModel> list = await new MovieService().GetMovieAsync(id);
            return list;
        }

        [HttpGet("{id}/{chapter}")]
        public async Task<List<QuoteModel>> GetQuote(string id)
        {
            List<QuoteModel> list = await new MovieService().GetMovieQuoteAsync(id);
            return list;
        }
    }
}