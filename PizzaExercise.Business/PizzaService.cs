using PizzaExercise.Data;
using PizzaExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Business
{
    /// <summary>
    /// PizzaWorker is the main business service we use for logic surrounding pizza orders
    /// </summary>
    public class PizzaService : PizzaServiceBase, IPizzaService
    {
        public PizzaService(IPizzaRepository repo)
        {
            PizzaRepo = repo;
        }

        /// <summary>
        /// GetGroupedPizzas() retrieves all the pizza orders and group them based on toppings
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PizzaGroupResult>> GetGroupedPizzas()
        {
            var pizzas = await PizzaRepo.GetAllPizzas();

            if (pizzas == null) return null;

            var groupedResult = pizzas.GroupBy(x => x.Toppings, HashSet<string>.CreateSetComparer())
                .Select(x => new PizzaGroupResult { Toppings = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            return groupedResult;
        }
    }
}
