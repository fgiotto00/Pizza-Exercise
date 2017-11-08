using PizzaExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Business
{
    public interface IPizzaService
    {
        Task<IEnumerable<PizzaGroupResult>> GetGroupedPizzas();
    }
}
