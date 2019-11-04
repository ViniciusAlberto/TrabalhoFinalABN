using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojista.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lojista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Order>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<Order>> Get()
        {
            try {
            return DataFake.DataFake.Orders().ToList();
            }
            catch (Exception e)
            {
                return NotFound("Não encontrado!!");

            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Order), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Order> Get(int id)
        {
            try { 
            return DataFake.DataFake.Orders().Where(x => x.ID == id).First();
            }
            catch (Exception e)
            {
                return NotFound("Não encontrado!!");

            }
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Order), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Post([FromBody] Order value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Order), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Put(int id, [FromBody] Order value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Order), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Delete(int id)
        {
        }
    }
}
