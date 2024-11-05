using clinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Routes : ControllerBase
    {
        private static List<RoutesClass> List_of_routes = new List<RoutesClass>() {
            new RoutesClass{ idDoctor=1,idPatient=1},
            new RoutesClass{ idDoctor=1,idPatient=2}
        };

        // GET: api/<Routes>
        [HttpGet]
        public IEnumerable<RoutesClass> Get()
        {
            return List_of_routes;
        }

        // GET api/<Routes>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Routes>
        [HttpPost]
        public RoutesClass Post([FromBody] RoutesClass value)
        {
            List_of_routes.Add(value);
            return value;
        }

        // PUT api/<Routes>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoutesClass value)
        {
            var index = List_of_routes.FindIndex(e => e.idPatient == id);
            List_of_routes[index] = value;
        }

        // DELETE api/<Routes>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = List_of_routes.FindIndex(e => e.idPatient == id);
            List_of_routes.RemoveAt(index);
        }
    }
}
