using PizzaExercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise.Business
{
    public class PizzaServiceBase
    {
        protected IPizzaRepository PizzaRepo { get; set; }
    }
}
