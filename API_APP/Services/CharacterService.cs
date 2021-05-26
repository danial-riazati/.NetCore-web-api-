using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using API_APP.Models;

namespace API_APP.Services
{
    public class CharacterService : Services
    {

        public async Task<List<CharacterModel>> GetCharacterAsync()
        {
            List<CharacterModel> cModelList = new List<CharacterModel>();
            try
            {
                Authentication();
                var res =  await client.GetAsync("character");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    CharacterModel characterModel = new CharacterModel();
                    characterModel.id = (string)x["_id"];
                    characterModel.birth = (string)x["birth"];
                    characterModel.height = (string)x["height"];
                    characterModel.death = (string)x["death"];
                    characterModel.gender = (string)x["gender"];
                    characterModel.name = (string)x["name"];
                    characterModel.race = (string)x["race"];
                    characterModel.spouse = (string)x["spouse"];
                    characterModel.wikiUrl = (string)x["wikiUrl"];
                    cModelList.Add(characterModel);
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

        public async Task<List<CharacterModel>> GetCharacterAsync(string id)
        {
            List<CharacterModel> cModelList = new List<CharacterModel>();
            try
            {
                Authentication();
                var res = await client.GetAsync($"character/{id}");
                var data = JObject.Parse(await res.Content.ReadAsStringAsync());
                JArray docs = (JArray)data["docs"];
                foreach (var x in docs)
                {
                    CharacterModel characterModel = new CharacterModel();
                    characterModel.id = (string)x["_id"];
                    characterModel.birth = (string)x["birth"];
                    characterModel.height = (string)x["height"];
                    characterModel.death = (string)x["death"];
                    characterModel.gender = (string)x["gender"];
                    characterModel.name = (string)x["name"];
                    characterModel.race = (string)x["race"];
                    characterModel.spouse = (string)x["spouse"];
                    characterModel.wikiUrl = (string)x["wikiUrl"];
                    cModelList.Add(characterModel);
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

        public async Task<List<QuoteModel>> GetCharacterQuoteAsync(string id)
        {
            List<QuoteModel> qModelList = new List<QuoteModel>();
            try
            {
                Authentication();
                var res = await client.GetAsync($"character/{id}/quote");
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
