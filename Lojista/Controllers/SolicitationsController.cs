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
        public ActionResult<IEnumerable<Solicitation>> Get()
        {
            return DataFake.DataFake.Solicitations();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Solicitation> Get(int id)
        {
            return DataFake.DataFake.Solicitations().Where(x => x.ID == id).FirstOrDefault(); 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
