using PizzaExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Models
{
    public class PizzaIndexViewModel
    {
        public List<PizzaGroupResult> Result { get; set; }
        public int TotalOrders { get; set; }
    }
}