using AutoMapper;
using Bl.DTO;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Profiles 
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeBl>()
                //.ForMember(customerBl=> customerBl.Id,customer=> customer)
                .ReverseMap();
        }
    }
}
