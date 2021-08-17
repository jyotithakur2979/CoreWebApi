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
    public class ClassCardController : ControllerBase
    {
        [HttpPost]
        public int AddAllClassCard(ClassCardRequest classCard)
        {

            ClassDetail ab = new ClassDetail();
            ab.Name = classCard.name;
            ab.Rollno = classCard.rollno;
            ab.Subject = classCard.subject;
            ab.Number = classCard.number;
            ab.CreateDate = DateTime.Now;
            ab.Status = true;
            
            jyotiContext dc = new jyotiContext();
            dc.ClassDetails.Add(ab);
            int isSave = dc.SaveChanges();

            return isSave;
        }
        [HttpPut("{id}")]
        public void UpdateData(int id, ClassCardRequest classCard )
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.ClassDetails.Where(a => a.Id == id).FirstOrDefault();
            ab.Name = classCard.name;
            ab.Rollno = classCard.rollno;
            ab.Subject = classCard.subject;
            ab.Number = classCard.number;
            ab.CreateDate = DateTime.Now;
            ab.Status = true;
            dc.SaveChanges();
           
        }
        [HttpDelete("{id}")]
        public void DeleteData(int id)
        {
            jyotiContext dc = new jyotiContext();
            var ab = dc.ClassDetails.Where(a => a.Id == id).FirstOrDefault();
            dc.ClassDetails.Remove(ab);
            dc.SaveChanges();


        }
        [HttpGet]
        public List<ClassDetail> getAllClass()
        {
            jyotiContext dc = new jyotiContext();
            var lstClassCard = dc.ClassDetails.ToList();

            return lstClassCard;
        }
        
    }
}
