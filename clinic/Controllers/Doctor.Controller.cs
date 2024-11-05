using clinic.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctor : ControllerBase
    {
        private static List<DoctorClass> List_of_doctors = new List<DoctorClass>() {
            new DoctorClass{id=1,name="ron",phone=05245623568,email="ron123@gmail.com",businessHours=45},
            new DoctorClass{id=2,name="tam",phone=05276695621,email="tam5621@gmail.com",businessHours=50}
        };
        // GET: api/<Doctor>
        [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return List_of_doctors;
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Doctor>
        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            List_of_doctors.Add(value);
            return value;
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var index= List_of_doctors.FindIndex(e=>e.id==id);
            List_of_doctors[index] = value;
        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = List_of_doctors.FindIndex(e => e.id == id);
            List_of_doctors.RemoveAt(index);
        }
    }
}
