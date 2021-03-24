using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string nom { get; set; }
        public float prix { get; set; }

        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        public string ingredients { get; set; }
    }
}
