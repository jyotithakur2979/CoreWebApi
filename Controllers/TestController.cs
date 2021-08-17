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
    public class TestController : ControllerBase
    {
        [HttpGet]
        public int getvalue(int id)
        {
           
            return id + 140 + 100 +100;
        }

        [HttpPost]
        public int Add(int roll)
        {
            return roll + 1006; 
        }

        [HttpPut]
        public bool Update(bool name)
        {
            return true;
        }

        [HttpDelete]
        public float Delete(float id)
        {
            return id = 12 + 14;
        }
    }
}
