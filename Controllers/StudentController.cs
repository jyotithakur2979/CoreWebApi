using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Response;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> lst = new List<Student>();
        public StudentController()
        {
            lst.Add(new Student() { Name = "Name", Age = 45, MobileNo = 123123123, RollNo = "Rl24324" });
            lst.Add(new Student() { Name = "Name2", Age = 46, MobileNo = 123123123, RollNo = "Rl24325" });
            //lst.Add(new Student() { Name = "Name3", Age = 47, MobileNo = 123123123, RollNo = "Rl24326" });
            //lst.Add(new Student() { Name = "Name4", Age = 48, MobileNo = 123123123, RollNo = "Rl24327" });
            //lst.Add(new Student() { Name = "Name5", Age = 49, MobileNo = 123123123, RollNo = "Rl24328" });
            //lst.Add(new Student() { Name = "Name6", Age = 50, MobileNo = 123123123, RollNo = "Rl24329" });
            //lst.Add(new Student() { Name = "Name7", Age = 51, MobileNo = 123123123, RollNo = "Rl24330" });
            //lst.Add(new Student() { Name = "Name8", Age = 51, MobileNo = 123123123, RollNo = "Rl24331" });
            //lst.Add(new Student() { Name = "Name9", Age = 53, MobileNo = 123123123, RollNo = "Rl24332" });
            //lst.Add(new Student() { Name = "Name10", Age = 54, MobileNo = 123123123, RollNo = "Rl24333" });
        }
        

        [HttpGet]
        public List<Student> getStudents()
        {  
            
            
            return lst;
        }
        [HttpPost]
        public List<Student> AddStudent(Student data)
        {
            lst.Add(new Student() { Name = data.Name, Age = data.Age, MobileNo = data.MobileNo, RollNo = data.RollNo});
            return lst;
        }
        [HttpPut("{index}")]
        public List<Student> UpdateData(int index,Student data)
        {
            lst[index].Name = data.Name;
            lst[index].Age = data.Age;
            lst[index].MobileNo = data.MobileNo;
            lst[index].RollNo = data.RollNo;
            return lst;
        }
        [HttpDelete("{index}")]
        public List<Student> DeleteData(int index)
        {
            lst.RemoveAt(index);
            return lst;
        }
    }
}
