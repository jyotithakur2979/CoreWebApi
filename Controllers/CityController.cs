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
    public class CityController : ControllerBase
    {
        [HttpPost]
        public int AddAllCity(CityRequest city)
        {
            City ab = new City();
            ab.City1 = city.city;

            jyotiContext dc = new jyotiContext();
            dc.Cities.Add(ab);
            int isSave = dc.SaveChanges();
            return isSave;
        }
        [HttpGet]
        public List<City> getAllCity()
        {
            jyotiContext dc = new jyotiContext();
            var lstCity = dc.Cities.ToList();
            return lstCity;
        }
        [HttpGet("{id}")]
        public City gettAllCityById(int id)
        {
            jyotiContext dc = new jyotiContext();
            var city = dc.Cities.Where(a => a.Id == id).FirstOrDefault();
            return city;

        }
        [HttpPut("{id}")]
        public void UpdateData(int id,CityRequest city)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.Cities.Where(a => a.Id == id).FirstOrDefault();
            ab.City1 = city.city;
            ab.Status = true;
            dc.SaveChanges();

        }

       
    }
}
