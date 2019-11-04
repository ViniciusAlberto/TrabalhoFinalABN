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
    public class BudgetsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Budget>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<Budget>> Get()
        {
            return DataFake.DataFake.Budgets().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Budget> Get(int id)
        {
            return DataFake.DataFake.Budgets().Where(x => x.ID == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Post([FromBody] Budget value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Put(int id, [FromBody] Budget value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Delete(int id)
        {
        }
    }
}
