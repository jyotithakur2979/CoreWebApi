using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Entity;
using CoreWebApi.Requests;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClgController : ControllerBase
    {
        [HttpGet]
        public List<Clg> getAllClg()
        {
            jyotiContext dc = new jyotiContext();
            var lstClg = dc.Clgs.ToList();

            return lstClg;
        }



        [HttpGet("{id}")]
        public Clg getClgById(int id)
        {
            jyotiContext dc = new jyotiContext();
            var clg = dc.Clgs.Where(a => a.Id == id).FirstOrDefault();

            return clg;
        }



        [HttpPost]
        public int AddAllClg(ClgRequest clg)
        {
            Clg ab = new Clg();
            ab.Name = clg.name;
            ab.Mobileno = clg.mobileno;
            jyotiContext dc = new jyotiContext();
            dc.Clgs.Add(ab);
            int isSave = dc.SaveChanges();

            return isSave;

        }


        [HttpPut("{id}")]
        public void UpdateData( int id,ClgRequest clg)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.Clgs.Where(a => a.Id == id).FirstOrDefault();
            ab.Name = clg.name;
            ab.Mobileno = clg.mobileno;
            dc.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void DeleteData(int id)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.Clgs.Where(a => a.Id == id).FirstOrDefault();
            dc.Clgs.Remove(ab);
            dc.SaveChanges();
        }
    }
}
