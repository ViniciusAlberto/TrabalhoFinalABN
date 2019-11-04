using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lojista.DataFake;
using Lojista.Model;

namespace Lojista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitationsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Solicitation>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<Solicitation>> Get()
        {
            return DataFake.DataFake.Solicitations();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Solicitation), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Solicitation> Get(int id)
        {
            return DataFake.DataFake.Solicitations().Where(x => x.ID == id).FirstOrDefault(); 
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Solicitation), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Post([FromBody] Solicitation solicitation)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Solicitation), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Put(int id, [FromBody] Solicitation solicitation)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Solicitation), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public void Delete(int id)
        {

           
        }

    }
}
