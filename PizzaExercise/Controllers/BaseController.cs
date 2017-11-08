using PizzaExercise.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaExercise.Controllers
{
    public class BaseController : Controller
    {
        protected IPizzaService PizzaService { get; set; }
    }

}