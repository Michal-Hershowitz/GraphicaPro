using AutoMapper;
using Bl.DTO;
using Bl.Entities;
using Bl.Interface;
using Dal.Interface;
using Dal.Entities;

namespace Bl

{
    public class FunctionContractBL : IFunctionContractBl
    {

        IServicesContract services;
        IMapper mapper;
        public FunctionContractBL(IServicesContract services, IMapper mapper)
        {
            this.services = services;
            this.mapper = mapper;
        }

        public async Task<ContractBl> Create(ContractBl addition)
        {
            Contract contract = mapper.Map<Contract>(addition);
            Contract contract1 = await services.Create(contract);
            return mapper.Map<ContractBl>(contract1);
        }

        public async Task<List<ContractBl>> Get()
        {
            List<Contract> contracts = await services.Get();
            List<ContractBl> x = mapper.Map<List<ContractBl>>(contracts);
            return x;
            // throw new NotImplementedException();

        }

        public async Task<ContractBl> Get(string id)
        {
            Contract contract = await services.Get(id);
            return mapper.Map<ContractBl>(contract);
        }

        public async Task Remove(string id)
        {
            await services.Remove(id);
        }

        public async Task Update(string id, ContractBl addition)
        {
            Contract contract = mapper.Map<Contract>(addition);
            await services.Update(id, contract);
        }
    }
}