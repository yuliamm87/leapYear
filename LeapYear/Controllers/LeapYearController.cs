using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeapYear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeapYearController : ControllerBase
    {
        //// GET api/values   
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{year}")]
        public ActionResult<bool> Get(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 100 == 0) {
                return false;
            }

            return year % 4 == 0;
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
