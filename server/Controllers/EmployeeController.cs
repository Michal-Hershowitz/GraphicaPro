//using Microsoft.AspNetCore.Mvc;
//using Dal.Models;
//using Dal.Services;
//using Microsoft.AspNetCore.Cors;
//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace server.Controllers
//{
//    [Route("api/[controller]")]
//    [EnableCors]
//    [ApiController]
//    public class EmployeeController : ControllerBase
//    {
//        private readonly ICrud<Employee> servicesEmployee;
//        public EmployeeController(ICrud<Employee> servicesEmployee)
//        {
//            this.servicesEmployee = servicesEmployee;
//        }
//        // GET: api/<EmployeeController>
//        [HttpGet]
//        public ActionResult<List<Employee>> Get()
//        {
//            return servicesEmployee.Get();
//        }

//        // GET api/<EmployeeController>/5
//        [HttpGet("{id}")]
//        public ActionResult<Employee> Get(string id)
//        {
//             var employee = servicesEmployee.Get(id);

//            if (employee == null)
//            {
//                return NotFound($"Employee with Id = {id} not found");
//            }
//            return employee;
//        }

//        // POST api/<EmployeeController>
//        [HttpPost]
//        public ActionResult<Employee> Post([FromBody] Employee employee)
//        {
//            employee.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
//            servicesEmployee.Create(employee);
//            return CreatedAtAction(nameof(Get), new {id= employee.Id },employee);
//        }

//        // PUT api/<EmployeeController>/5
//        [HttpPut("{id}")]
//        public ActionResult Put(string id, [FromBody] Employee employee)
//        {
//            var existingEmployee = servicesEmployee.Get(id);
//            if (existingEmployee==null) 
//            { 
//                return NotFound($"Employee with Id = {id} not found");
//            }
//            servicesEmployee.Update(id,employee);
//            return NoContent();
//        }

//        // DELETE api/<EmployeeController>/5
//        [HttpDelete("{id}")]
//        public ActionResult Delete(string id)
//        {
//            var employee = servicesEmployee.Get(id);
//            if(employee == null)
//            {
//                return NotFound($"Employee with Id = {id} not found");
//            }
//            servicesEmployee.Remove(employee.Id);
//            return Ok($"Employee with Id = {id} deleted");
//        }
//    }
//}
