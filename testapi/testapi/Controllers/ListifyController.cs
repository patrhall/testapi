using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    public class ListifyController : Controller
    {
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/listify/5/10/7
        [HttpGet("{start}/{end}/{index}")]
        public object Get(int start, int end, int index)
        {
            var noInList = start + index;
            if (noInList >= start - 1 && noInList <= end - 1)
            {
                var list = new Listify(start, end);
                return list[index];
            }
            else
            {
                return "Wrong";
            }  
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
