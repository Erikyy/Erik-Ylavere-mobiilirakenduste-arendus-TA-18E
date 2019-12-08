using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core.DataServices
{
    public class DataServiceFilms
    {
        public static async Task<Films> GetStarWarsFilms(string queryString)
        {
            var query = "https://swapi.co/api/films/";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Films data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Films>(response);
                return data;
            }
            return null;
        }
    }
}
