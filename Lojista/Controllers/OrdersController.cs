using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojista.DataFake;
using Lojista.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lojista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable<Order>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Order> Get(int id)
        {
            try
            {
                return DataFake.DataFake.Orders().Where(x => x.ID == id).First();
            }
             catch(Exception e)
            {
                return NotFound("Não encontrado!!");

            }
        }


    }
}
