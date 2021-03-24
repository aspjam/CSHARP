using Microsoft.AspNetCore.Mvc;
using pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizza = new Pizza() { nom="pizza test", prix=8, vegetarienne=false, ingredients="tomate, oignons, oeuf"};

            return Json(pizza);
        }



    }
}
