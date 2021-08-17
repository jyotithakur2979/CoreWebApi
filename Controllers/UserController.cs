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
    public class UserController : ControllerBase
    {
        [HttpGet]
        public List<ReportCard> getAllUser()
        {
            jyotiContext dc = new jyotiContext();
            List<ReportCard> lstReportCard = dc.ReportCards.ToList();

            return lstReportCard;
        }

        [HttpPost]
        public int AddAllUser(UserRequest usr)
        {
            UserMst obj = new UserMst();
            obj.MobileNo = usr.MobileNo;
            obj.UserEmail = usr.emailId;
            obj.UserName = usr.UserName;
            obj.UserPassword = usr.pwd;
            
            jyotiContext dc = new jyotiContext();
            dc.UserMsts.Add(obj);
            int isSave = dc.SaveChanges();

            return isSave;

        }

        [HttpPut("{id}")]
        public void UpdateUser(int id, UserRequest usr)
        {           

            jyotiContext dc = new jyotiContext();
            var ab = dc.UserMsts.Where(a => a.Id == id).FirstOrDefault();
            ab.MobileNo = usr.MobileNo;
            ab.UserEmail = usr.emailId;
            dc.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            //UserMst ab = new UserMst();
            jyotiContext dc = new jyotiContext();
            UserMst ab = dc.UserMsts.Where(a => a.Id == id).FirstOrDefault();
            dc.UserMsts.Remove(ab);
            dc.SaveChanges();
        }

    }
}
