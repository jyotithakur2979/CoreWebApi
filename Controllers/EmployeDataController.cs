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
    public class EmployeDataController : ControllerBase
    {
        [HttpPost]
        public int AddAllEmploye(EmployeDataRequest employeData)
        {

            EmployeDatum ab = new EmployeDatum();
            ab.Employename = employeData.employename;
            ab.Companyname = employeData.companyname;
            ab.Mobileno = employeData.mobileno;
            ab.Emailid = employeData.emailid;

            jyotiContext dc = new jyotiContext();
            dc.EmployeData.Add(ab);
            int isSave = dc.SaveChanges();

            return isSave;

        }
        [HttpGet]
         public List<EmployeDatum> getAllEmploye()
        {
            jyotiContext dc = new jyotiContext();
            var lstEmployeData = dc.EmployeData.ToList();

            List<EmployeDatum> filterData = new List<EmployeDatum>();
            foreach (var item in lstEmployeData)
            {
              filterData.Add(item);               
            }

            return filterData;
        }

        [HttpGet("{id}")]
        public EmployeDatum getEmployeById(int id)
        {
            jyotiContext dc = new jyotiContext();
            var employee = dc.EmployeData.Where(x => x.Id == id).FirstOrDefault();
            return employee;
        }

        [HttpPut("{id}")]
         public void UpdateData(int id,EmployeDataRequest employeData)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.EmployeData.Where(a => a.Id == id).ToList();

            foreach (var item in ab)
            {
                item.Employename = employeData.employename;
                item.Companyname = employeData.companyname;
                item.Mobileno = employeData.mobileno;
                item.Emailid = employeData.emailid;
                dc.SaveChanges();
            }    
            
        }
        [HttpDelete("{id}")]
        public void DeleteData(int id)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.EmployeData.Where(a => a.Id == id).ToList();
            dc.EmployeData.RemoveRange(ab);
            dc.SaveChanges();
                
        }
    }
}
