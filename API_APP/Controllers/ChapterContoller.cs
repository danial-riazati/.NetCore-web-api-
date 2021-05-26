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
    [Route("api/chapter")]
    [ApiController]
    public class ChapterController : ControllerBase
    {

        [HttpGet]
        public async Task<List<ChapterModel>> Get() { 
            List<ChapterModel> list = await new ChapterService().GetChapterAsync();
          return list;
        }

        [HttpGet("{id}")]
        public async Task<List<ChapterModel>> Get(string id)
        {
           List<ChapterModel> list = await new ChapterService().GetChapterAsync(id);
            return list;
        }
    }
}