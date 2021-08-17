using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public String getInfo(String name)
        {
            
            return "some value" + "other value";
        }


        [HttpPost]
        public string save(String age)
        {
            return "age" + 27;
        }

        [HttpPut]
        public string Update(string abs)
        {
            return " class" + "abs" ;
        }

        [HttpDelete]
        public string Delete(string name)
        {
            return "name" + "class";
        }
    }
}
