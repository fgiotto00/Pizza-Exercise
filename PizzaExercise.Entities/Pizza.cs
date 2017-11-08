using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Entities
{
    /// <summary>
    /// Pizza Class is the main class for holding pizza information
    /// </summary>
    public class Pizza
    {
        public HashSet<string> Toppings { get; set; }
    }
}
