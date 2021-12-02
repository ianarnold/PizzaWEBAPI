using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWEBAPI.Models;
using PizzaWEBAPI.Services;

namespace PizzaWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        // GET (ALL Pizzas)
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();  

        // GET (Pelo ID)
        [HttpGet("{id}")]                              
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);
            if (pizza == null) {
                return NotFound();
            } else {
                return pizza;
            }
        }

        // POST action

        // PUT action

        // DELETE action
    }
}