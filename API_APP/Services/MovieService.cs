using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using API_APP.Models;

namespace API_APP.Services
{
    public class MovieService : Services
    { 
        public async Task<List<MovieModel>> GetMovieAsync()
        {
            List<MovieModel> mModelList = new List<MovieModel>();
           
            try
            {
                Authentication();
                
                var res =  await client.GetAsync("movie");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());

                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    MovieModel movieModel = new MovieModel();
                    movieModel.id = (string)x["_id"];
                    movieModel.name = (string)x["name"];
                    movieModel.runtimeInMinutes = (int)x["runtimeInMinutes"];
                    movieModel.budgetInMillions = (int)x["budgetInMillions"];
                    movieModel.academyAwardWins = (int)x["academyAwardWins"];
                    movieModel.boxOfficeRevenueInMillions = (int)x["boxOfficeRevenueInMillions"];
                    mModelList.Add(movieModel);
                }
                return mModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return mModelList;
            }

        }

        public async Task<List<MovieModel>> GetMovieAsync(string id)
        {
            List<MovieModel> mModelList = new List<MovieModel>();

            try
            {
                Authentication();
                var res = await client.GetAsync($"movie/{id}");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());

                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    MovieModel movieModel = new MovieModel();
                    movieModel.id = (string)x["_id"];
                    movieModel.name = (string)x["name"];
                    movieModel.runtimeInMinutes = (int)x["runtimeInMinutes"];
                    movieModel.budgetInMillions = (int)x["budgetInMillions"];
                    movieModel.academyAwardWins = (int)x["academyAwardWins"];
                    movieModel.boxOfficeRevenueInMillions = (int)x["boxOfficeRevenueInMillions"];
                    mModelList.Add(movieModel);
                }
                return mModelList;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return mModelList;
            }

        }

        public async Task<List<QuoteModel>> GetMovieQuoteAsync(string id)
        {
            List<QuoteModel> qModelList = new List<QuoteModel>();

            try
            {
                Authentication();
                var res = await client.GetAsync($"movie/{id}/quote");
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
