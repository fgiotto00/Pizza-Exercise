using Newtonsoft.Json;
using PizzaExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Data
{
    public class PizzaRepository : IPizzaRepository
    {
        /// <summary>
        /// GetAllPizzas returns all pizza orders from the json pizza service
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Pizza>> GetAllPizzas()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync( new Uri("http://files.olo.com/pizzas.json"));
                if(response.IsSuccessStatusCode)
                {
                    var resultString = await response.Content.ReadAsStringAsync();
                    var pizzas = JsonConvert.DeserializeObject<IEnumerable<Pizza>>(resultString);
                    return pizzas;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
