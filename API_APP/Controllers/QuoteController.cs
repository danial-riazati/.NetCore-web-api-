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
    [Route("api/quote")]
    [ApiController]
    public class QuoteController : ControllerBase
    {

        [HttpGet]
        public async Task<List<QuoteModel>> Get() { 
            List<QuoteModel> list = await new QuoteService().GetQuoteAsync();
          return list;
        }

        [HttpGet("{id}")]
        public async Task<List<QuoteModel>> Get(string id)
        {
           List<QuoteModel> list = await new QuoteService().GetQuoteAsync(id);
            return list;
        }
    }
}