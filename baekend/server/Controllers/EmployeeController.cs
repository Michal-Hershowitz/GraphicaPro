using Microsoft.AspNetCore.Mvc;
using Dal.Models;
using Dal.Services;
using Microsoft.AspNetCore.Cors;
using Bl.Interface;
using Bl.DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    public class EmployeeController : ControllerBase

    {
        IFunctionEmployeeBl servicesEmployee;
        //private readonly ICrud<Customer> servicesCustomer;
        public EmployeeController(/*ICrud<Customer> servicesCustomer*/ IFunctionEmployeeBl servicesEmployee)
        {
            this.servicesEmployee = servicesEmployee;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<List<EmployeeBl>> Get()
        {
            return await servicesEmployee.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<EmployeeBl> Get(string id)
        {
            EmployeeBl employee = await servicesEmployee.Get(id);

            if (employee == null)
            {
                //return NotFound ($"Customer with Id = {id} not found");
            }
            return employee;
        }

        // POST api/<CustomerController>
        [HttpPost("post")]
        public async Task<EmployeeBl> Post([FromBody] EmployeeBl employee)
        {
            EmployeeBl employees1 = await servicesEmployee.Create(employee);
            return employees1; /*CreatedAtAction(nameof(Get), new {id= customer.Id }, customer);*/
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] EmployeeBl employee)
        {
            EmployeeBl existingEmployee = await servicesEmployee.Get(id);
            if (existingEmployee == null)
            {
                // return NotFound($"Customer with Id = {id} not found");
            }
            await servicesEmployee.Update(id, existingEmployee);
            //return NoContent();
            //return await servicesCustomer.Update(id,);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            EmployeeBl employee = await servicesEmployee.Get(id);
            if (employee == null)
            {
                //return NotFound($"Employee with Id = {id} not found");
            }
            await servicesEmployee.Remove(employee.Id);
            //return Ok($"Customer with Id = {id} deleted");
        }
    }
}
