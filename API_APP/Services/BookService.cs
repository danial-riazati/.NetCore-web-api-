using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using API_APP.Models;

namespace API_APP.Services
{
    public class BookService : Services
    {

        public async Task<List<BookModel>> GetBookAsync()
        {
            List<BookModel> bModelList = new List<BookModel>();
            try
            {
                Authentication();
                var res =  await client.GetAsync("book");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    BookModel bookModel = new BookModel();
                    bookModel.id = (string)x["_id"];
                    bookModel.name = (string)x["name"];
                    bModelList.Add(bookModel);
                }
                return bModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return bModelList;
            }

        }

        public  async Task<List<BookModel>> GetBookAsync(string id)
        {
            List<BookModel> bModelList = new List<BookModel>();
            try
            {
                var res = await client.GetAsync($"book/{id}");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());

                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    BookModel bookModel = new BookModel();
                    bookModel.id = (string)x["_id"];
                    bookModel.name = (string)x["name"];
                    bModelList.Add(bookModel);
                }
                return bModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return bModelList;
            }

        }

        public  async Task<List<ChapterModel>> GetBookChapterAsync(string id)
        {
            List<ChapterModel> cModelList = new List<ChapterModel>();
          
            try
            {
                var res = await client.GetAsync($"book/{id}/chapter");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());

                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    ChapterModel chapterModel = new ChapterModel();
                    chapterModel.id = (string)x["_id"];
                    chapterModel.chapterName = (string)x["chapterName"];
                    chapterModel.book = id;
                    cModelList.Add(chapterModel);
                }
                return cModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return cModelList;
            }

        }
    }
}
