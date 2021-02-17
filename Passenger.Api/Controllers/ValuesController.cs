using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Passenger.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // //POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value1)]
        // {
        // }

        // //PUT api/values/5
        // [ HttpPut("{id}")]
        // publi void Put(int id, [FromBody] string value)
        // {
        // }

        //Delete api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }

    
}