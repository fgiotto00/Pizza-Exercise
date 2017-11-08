using PizzaExercise.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaExercise.Data
{
    public interface IPizzaRepository
    {
        Task<IEnumerable<Pizza>> GetAllPizzas();
    }
}
