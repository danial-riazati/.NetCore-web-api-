using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using API_APP.Models;

namespace API_APP.Services
{
    public class QuoteService : Services
    {

        public async Task<List<QuoteModel>> GetQuoteAsync()
        {
            List<QuoteModel> qModelList = new List<QuoteModel>();
            try
            {
                Authentication();
                var res =  await client.GetAsync("quote");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    QuoteModel quoteModel = new QuoteModel();
                    quoteModel.id = (string)x["_id"];
                    quoteModel.dialog = (string)x["dialog"];
                    quoteModel.movie = (string)x["movie"];
                    quoteModel.character = (string)x["character"];
                    qModelList.Add(quoteModel);
                }
                return qModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return qModelList;
            }

        }

        public  async Task<List<QuoteModel>> GetQuoteAsync(string id)
        {
            List<QuoteModel> qModelList = new List<QuoteModel>();
            try
            {
                Authentication();

                var res = await client.GetAsync($"quote/{id}");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());

                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    QuoteModel quoteModel = new QuoteModel();
                    quoteModel.id = (string)x["_id"];
                    quoteModel.dialog = (string)x["dialog"];
                    quoteModel.movie = (string)x["movie"];
                    quoteModel.character = (string)x["character"];
                    qModelList.Add(quoteModel);
                }
                return qModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return qModelList;
            }

        }
    }
}
