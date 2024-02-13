using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bl.DTO;
using Bl.Entities;
using Dal.Entities;

namespace Bl.Profiles
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Contract, ContractBl>().ReverseMap();
        }
    }
}
