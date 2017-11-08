using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Entities
{
    /// <summary>
    /// PizzaGroupResult is the resulting object used after grouping pizza orders per topping
    /// </summary>
    public class PizzaGroupResult
    {
        public HashSet<string> Toppings { get; set; }
        public int Count { get; set; }
    }
}
