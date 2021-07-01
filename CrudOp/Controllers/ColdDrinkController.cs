using CrudOp.Models;
using CrudOp.Models.Repository;
using CrudOp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CrudOp.Controllers
{
    

    
    [ApiController]
    public class ColdDrinkController : ControllerBase
    {
        private readonly DrinkRepository<ColdDrink> _Instance;
        public ColdDrinkController(DrinkRepository<ColdDrink> dataRepository)
        {
            _Instance = dataRepository;
        }

        [HttpGet]
        [Route("api/ColdDrink")]
        public IActionResult Get()
        {

            IEnumerable<ColdDrink> coldDrinks= (List<ColdDrink>)_Instance.GetAllColdDrink();

            return Ok(coldDrinks);
        }
        [HttpGet("{Id}", Name = "Get")]
        [Route("api/ColdDrink/{Id}")]
        public IActionResult Get(int Id)
        {
            ColdDrink coldDrink= _Instance.GetColdDrinkById(Id);

            return Ok(coldDrink);
        }
        [HttpPost]
        [Route("api/ColdDrink")]
        public IActionResult Post(ColdDrink coldDrink)
        {
            

            _Instance.SaveColdDrink(coldDrink);

            return CreatedAtRoute(
                  "Get",
                  new { Id = coldDrink.intColdDrinksId },
                  coldDrink);
        }
        [HttpPatch]
        [Route("api/ColdDrink/{Id}")]
        public IActionResult Put(int Id, [FromBody] ColdDrink coldDrink)
        {

            ColdDrink findcoldDrink = _Instance.GetColdDrinkById(Id);
            if (findcoldDrink == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _Instance.UpdateColdDrink(findcoldDrink, coldDrink);
            return Ok();
        }
        [HttpDelete]
        [Route("api/ColdDrink/{Id}")]
        public IActionResult Delete(int Id)
        {
            _Instance.DeleteColdDrink(Id);

            return Ok();
        }
        [HttpGet]
        [Route("api/ColdDrink/Total")]
        public IActionResult TotalPrice()
        {

            return base.Ok(_Instance.GetTotalPrice());
        }
        [HttpGet]
        [Route("api/ColdDrink/ProductName")]
        public IActionResult ProductName()
        {

            //var pName =_Instance.GetProductName();
            return Ok(_Instance.GetProductName());
        }
    }
}
