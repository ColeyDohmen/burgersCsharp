using System.Collections.Generic;
using burgers.DB.cs;
using burgers.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(FakeDB.Burgers);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burger> Create([FromBody] Burger newBurger)
        {
            try
            {
                FakeDB.Burgers.Add(newBurger);
                return Ok(newBurger);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

    }
}