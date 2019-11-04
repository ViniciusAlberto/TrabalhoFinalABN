using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lojista.DataFake;
using Lojista.Model;
using System.Web.Http;



namespace Lojista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
      
        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Budget> Get(int id)
        {
            try
            {
                return DataFake.DataFake.Budgets().Where(x => x.ID == id).First();
            }
            catch(Exception e)
            {
                return NotFound("Não encontrado!!");
            }
        }

        // POST api/values

        [HttpPut("{id}/Reject")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Budget> Reject([FromRoute] int id) {

          
            var budget =  DataFake.DataFake.Budgets().Where(x => x.ID == id).First();

            if (budget != null)
            {
                budget.Status = false;

                return budget;
            }
            else
            {        
                return NotFound("Não encontrado!!");
            
            }
          
        }


        [HttpPut("{id}/Approved")]
        [ProducesResponseType(typeof(Budget), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Budget> Approved([FromRoute] int id)
        {

            var budget = DataFake.DataFake.Budgets().Where(x => x.ID == id).First();

            if (budget != null)
            {
                budget.Status =true;

                return budget;
            }
            else
            {
                return NotFound("Não encontrado!!");

            }

        }
    }
}
