using AutoMapper;
using Bl.DTO;
using Bl.Interface;
using Dal.Interface;
using Dal.Models;

namespace Bl

{
    public class FunctionCustomerBL : IFunctionCustomerBl
    {

        IServicesCustomer services;
        IMapper mapper;
        public FunctionCustomerBL(IServicesCustomer services, IMapper mapper)
        {
            this.services = services;
            this.mapper = mapper;
        }

        public async Task<CustomerBl> Create(CustomerBl addition)
        {
            Customer customer = mapper.Map<Customer>(addition);
            Customer customer1 = await services.Create(customer);
            return mapper.Map<CustomerBl>(customer1);
        }

        public async Task<List<CustomerBl>> Get()
        {
            List<Customer> customers = await services.Get();
            List<CustomerBl> x = mapper.Map<List<CustomerBl>>(customers);
            return x;
            // throw new NotImplementedException();

        }

        public async Task<CustomerBl> Get(string id)
        {
            Customer customer = await services.Get(id);
            return mapper.Map<CustomerBl>(customer);
        }

        public async Task Remove(string id)
        {
            await services.Remove(id);
        }

        public async Task Update(string id, CustomerBl addition)
        {
            Customer customer = mapper.Map<Customer>(addition);
            await services.Update(id, customer);
        }
    }
}