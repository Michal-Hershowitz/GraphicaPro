using AutoMapper;
using Bl.DTO;
using Bl.Interface;
using Dal.Interface;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class FunctionEmployeeBL : IFunctionEmployeeBl
    {
        IServicesEmployee services;
        IMapper mapper;
        public FunctionEmployeeBL(IServicesEmployee services, IMapper mapper)
        {
            this.services = services;
            this.mapper = mapper;
        }

        public async Task<EmployeeBl> Create(EmployeeBl addition)
        {
            Employee employee = mapper.Map<Employee>(addition);
            Employee employee1 = await services.Create(employee);
            return mapper.Map<EmployeeBl>(employee1);
        }

        public async Task<List<EmployeeBl>> Get()
        {
            List<Employee> employees = await services.Get();
            List<EmployeeBl> x = mapper.Map<List<EmployeeBl>>(employees);
            return x;
            // throw new NotImplementedException();

        }

        public async Task<EmployeeBl> Get(string id)
        {
            Employee employee = await services.Get(id);
            return mapper.Map<EmployeeBl>(employee);
        }

        public async Task Remove(string id)
        {
            await services.Remove(id);
        }

        public async Task Update(string id, EmployeeBl addition)
        {
            Employee employee = mapper.Map<Employee>(addition);
            await services.Update(id, employee);
        }
    }
}
