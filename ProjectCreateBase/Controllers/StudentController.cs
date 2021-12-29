using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCreateBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCreateBase.Models;

namespace ProjectCreateBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SocolarityContext _context;

        public StudentController(SocolarityContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void AddStudent()
        {
            var student1 = new Student
            {
                FirstName="Med Amine",
                LastName ="Ben Noureddine",
                Datebirthday = new DateTime(1995,10,5)
            };
            var student2 = new Student
            {
                FirstName = "Med Amine",
                LastName = "Ben Noureddine",
                Datebirthday = new DateTime(1995, 10, 5)
            };

            _context.Students.Add(student2);
            _context.Students.Add(student1);

            _context.SaveChanges();

            var teacher = new Teacher
            {
                FirstName = "Farouk",
                LastName = "Ferjani",
                Datebirthday = new DateTime(1990, 10, 5),
                Students = new List<Student>
                {
                    student2
                }
            };
            _context.Teachers.Add(teacher);


            _context.SaveChanges();
        }

    }
}
