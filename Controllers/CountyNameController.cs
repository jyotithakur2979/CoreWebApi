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
    public class CountyNameController : ControllerBase
    {
        [HttpPost]
        public int AddAllCountryName(CountryNameRequest countryName)
        {
            CountryName ab = new CountryName();
            ab.Countryname1 = countryName.countryname;
            ab.Status = true;

            jyotiContext dc = new jyotiContext();
            dc.CountryNames.Add(ab);
            int isSave = dc.SaveChanges();
            return isSave;
        }
        [HttpGet]
        public List<CountryName> getAllCountryName()
        {
            CountryName ab = new CountryName();
            jyotiContext dc = new jyotiContext();
            var lstCountryName = dc.CountryNames.ToList();
            return lstCountryName;
        }
        [HttpGet("{id}")]
        public CountryName getCountryNameById(int id)
        {
            jyotiContext dc = new jyotiContext();
            var country = dc.CountryNames.Where(x => x.Id == id).FirstOrDefault();
            return country;
        }
        [HttpPut("{id}")]
        public void UpdateData(int id,CountryNameRequest countryName)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.CountryNames.Where(a => a.Id == id).FirstOrDefault();
            ab.Countryname1 = countryName.countryname;
            ab.Status = true;
            dc.SaveChanges();

        }
        
 
    }
}
