using Microsoft.AspNetCore.Mvc;
using Dal.Models;
using Dal.Services;
using Microsoft.AspNetCore.Cors;
using Bl.DTO;
using Bl.Interface;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    public class CustomerController : ControllerBase

    {
        IFunctionCustomerBl servicesCustomer;
        //private readonly ICrud<Customer> servicesCustomer;
        public CustomerController(/*ICrud<Customer> servicesCustomer*/ IFunctionCustomerBl servicesCustomer)
        {
            this.servicesCustomer = servicesCustomer;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<List<CustomerBl>> Get()
        {
            return await servicesCustomer.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<CustomerBl> Get(string id)
        {
            CustomerBl customer = await servicesCustomer.Get(id);

            if (customer == null)
            {
                //return NotFound ($"Customer with Id = {id} not found");
            }
            return customer;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<CustomerBl> Post([FromBody] CustomerBl customer)
        {
            CustomerBl customer1 = await servicesCustomer.Create(customer);
            //CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
            return customer1; 
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] CustomerBl customer)
        {
            CustomerBl existingCustomer = await servicesCustomer.Get(id);
            if (existingCustomer == null)
            {
                // return NotFound($"Customer with Id = {id} not found");
            }
            await servicesCustomer.Update(id, existingCustomer);
            //return NoContent();
            //return await servicesCustomer.Update(id,);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            CustomerBl customer = await servicesCustomer.Get(id);
            if (customer == null)
            {
                //return NotFound($"Employee with Id = {id} not found");
            }
            await servicesCustomer.Remove(customer.Id);
            //return Ok($"Customer with Id = {id} deleted");
        }
    }
}
