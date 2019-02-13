using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoffeeApp.Model;
using Newtonsoft.Json;

namespace CoffeeApp.Myapi
{
    public class GApi
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<GModel>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<GModel>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
} 
        

    

