using clinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class patient : ControllerBase
    {
        private static List<PatientClass> List_of_patient = new List<PatientClass>() {
            new PatientClass{id=1,name="dan",phone=0125968534,email="dan6@gmail.com",address="tisrei 4",city="tel aviv"},
            new PatientClass{id=12,name="yael",phone=0527894562,email="yael@gmail.com",address="ben neria 2",city="bney brak"}
    };



    // GET: api/<patient>
    [HttpGet]
        public IEnumerable<PatientClass> Get()
        {
            return List_of_patient;
        }

        // GET api/<patient>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<patient>
        [HttpPost]
        public PatientClass Post([FromBody] PatientClass value)
        {
            List_of_patient.Add(value);
            return value;
        }

        // PUT api/<patient>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PatientClass value)
        {
            var index = List_of_patient.FindIndex(e => e.id == id);
            List_of_patient[index] = value;
        }

        // DELETE api/<patient>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = List_of_patient.FindIndex(e => e.id == id);
            List_of_patient.RemoveAt(index);
        }
    }
}
