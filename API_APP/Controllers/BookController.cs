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
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {

        [HttpGet]
        public async Task<List<BookModel>> Get()
        {
            List<BookModel> list = await new BookService().GetBookAsync();
            return list;
        }

        [HttpGet("{id}")]
        public async Task<List<BookModel>> Get(string id)
        {
            List<BookModel> list = await new BookService().GetBookAsync(id);
            return list;
        }

        [HttpGet("{id}/{chapter}")]
        public async Task<List<ChapterModel>> GetChapter(string id)
        {
            List<ChapterModel> list = await new BookService().GetBookChapterAsync(id);
            return list;
        }
    }
}