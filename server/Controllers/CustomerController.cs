using Microsoft.AspNetCore.Mvc;
using Dal.Models;
using Dal.Services;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICrud<Customer> servicesCustomer;
        public CustomerController(ICrud<Customer> servicesCustomer)
        {
            this.servicesCustomer = servicesCustomer;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return servicesCustomer.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(string id)
        {
             var customer = servicesCustomer.Get(id);

            if (customer == null)
            {
                return NotFound($"Customer with Id = {id} not found");
            }
            return customer;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            servicesCustomer.Create(customer);
            return CreatedAtAction(nameof(Get), new {id= customer.Id }, customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Customer customer)
        {
            var existingCustomer = servicesCustomer.Get(id);
            if (existingCustomer == null) 
            { 
                return NotFound($"Customer with Id = {id} not found");
            }
            servicesCustomer.Update(id, customer);
            return NoContent();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var customer = servicesCustomer.Get(id);
            if(customer == null)
            {
                return NotFound($"Employee with Id = {id} not found");
            }
            servicesCustomer.Remove(customer.Id);
            return Ok($"Customer with Id = {id} deleted");
        }
    }
}
