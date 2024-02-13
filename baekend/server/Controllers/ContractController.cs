using Microsoft.AspNetCore.Mvc;
using Dal.Models;
using Dal.Services;
using Microsoft.AspNetCore.Cors;
using Bl.Interface;
using Bl.DTO;
using Bl.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    public class ContractController : ControllerBase

    {
        IFunctionContractBl servicesContract;
        //private readonly ICrud<Customer> servicesCustomer;
        public ContractController(/*ICrud<Customer> servicesCustomer*/ IFunctionContractBl servicesContract)
        {
            this.servicesContract = servicesContract;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<List<ContractBl>> Get()
        {
            return await servicesContract.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ContractBl> Get(string id)
        {
            ContractBl contract = await servicesContract.Get(id);

            if (contract == null)
            {
                //return NotFound ($"Customer with Id = {id} not found");
            }
            return contract;
        }

        // POST api/<CustomerController>
        [HttpPost("post")]
        public async Task<ContractBl> Post([FromBody] ContractBl contract)
        {
            ContractBl contract1 = await servicesContract.Create(contract);
            return contract1; /*CreatedAtAction(nameof(Get), new {id= customer.Id }, customer);*/
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] ContractBl contract)
        {
            ContractBl existingContract = await servicesContract.Get(id);
            if (existingContract == null)
            {
                // return NotFound($"Customer with Id = {id} not found");
            }
            await servicesContract.Update(id, existingContract);
            //return NoContent();
            //return await servicesCustomer.Update(id,);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            ContractBl contract = await servicesContract.Get(id);
            if (contract == null)
            {
                //return NotFound($"Employee with Id = {id} not found");
            }
            await servicesContract.Remove(contract.Id);
            //return Ok($"Customer with Id = {id} deleted");
        }
    }
}
