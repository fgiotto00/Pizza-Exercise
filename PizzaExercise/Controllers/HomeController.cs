using PizzaExercise.Business;
using PizzaExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PizzaExercise.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IPizzaService worker)
        {
            PizzaService = worker;
        }

        public async Task<ActionResult> Index()
        {
            var pizzaResult = await PizzaService.GetGroupedPizzas();

            var model = new PizzaIndexViewModel() {
                Result = pizzaResult?.Take(20).ToList(),
                TotalOrders = pizzaResult != null ? pizzaResult.Sum(x => x.Count) : 0
            };

            return View(model);
        }
    }
}