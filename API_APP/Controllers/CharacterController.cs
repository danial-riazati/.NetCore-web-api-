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
    [Route("api/character")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
      

            [HttpGet]
            public async Task<List<CharacterModel>> Get()
            {
                List<CharacterModel> list = await new CharacterService().GetCharacterAsync();
                return list;
            }

            [HttpGet("{id}")]
            public async Task<List<CharacterModel>> Get(string id)
            {
                List<CharacterModel> list = await new CharacterService().GetCharacterAsync(id);
            return list;
            }

            [HttpGet("{id}/{character}")]
            public async Task<List<QuoteModel>> GetQuote(string id)
            {
                List<QuoteModel> list = await new CharacterService().GetCharacterQuoteAsync(id);
            return list;
            }
        

    }
}