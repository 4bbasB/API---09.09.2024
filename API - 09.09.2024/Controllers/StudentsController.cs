using API___09._09._2024.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API___09._09._2024.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student()
            {
                Fullname = "Abbase Bayramli",
                Grade = 13,
                Id = 1
            },
            new Student()
            {
                Fullname = "Bilal Bayramov",
                Grade = 14,
                Id = 2
            },
            new Student()
            {
                Fullname = "Ebil Ezizov",
                Grade = 10,
                Id = 3
            }
        };

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var std = _students.FirstOrDefault(x => x.Id == id);
            return Ok(std);
        }


        [HttpPost]
        public IActionResult Create([FromBody]Student student)
        {
            _students.Add(student);

            return Created();
        }


        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Student student)
        {
           var std = _students.Find(x => x.Id == id);

            std.Fullname = student.Fullname;
            std.Grade = student.Grade;

            return Ok(std);
        }
    }
}
