using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private TaxProductContext _context;


        public ValuesController(TaxProductContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
		[Route("GetName")]
        public ActionResult<IEnumerable<string>> Get()
        {
            var result = (from s in _context.TblEmployees.AsEnumerable().Where(x => x.SkillId !=null) select s.EmployeeName).ToList();
            //return new string[] { "Rahul", "Kumar" };
            result.Add( "All Employee Names:----");
            return result;
        }

        // GET api/values/5
      

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
