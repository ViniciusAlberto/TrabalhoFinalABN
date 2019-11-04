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
            try
            {
                return DataFake.DataFake.Solicitations();
            }
            catch (Exception e)
            {
                return NotFound("Não encontrado!!");

            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Solicitation), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Solicitation> Get(int id)
        {
            try
            {
                return DataFake.DataFake.Solicitations().Where(x => x.ID == id).First();
            }
            catch (Exception e)
            {
                return NotFound("Não encontrado!!");

            }
        }

    }
}
