using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using API_APP.Models;

namespace API_APP.Services
{
    public class ChapterService : Services
    {

        public async Task<List<ChapterModel>> GetChapterAsync()
        {
            List<ChapterModel> cModelList = new List<ChapterModel>();
            try
            {
                Authentication();
                var res =  await client.GetAsync("chapter");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    ChapterModel chapterModel = new ChapterModel();
                    chapterModel.id = (string)x["_id"];
                    chapterModel.chapterName = (string)x["chapterName"];
                    chapterModel.book = (string)x["book"];
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

        public  async Task<List<ChapterModel>> GetChapterAsync(string id)
        {
            List<ChapterModel> cModelList = new List<ChapterModel>();
            try
            {
                Authentication();
                var res = await client.GetAsync($"chapter/{id}");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    ChapterModel chapterModel = new ChapterModel();
                    chapterModel.id = (string)x["_id"];
                    chapterModel.chapterName = (string)x["chapterName"];
                    chapterModel.book = (string)x["book"];
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
