using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;

namespace Dal.Services
{
    public interface IServicesEmployee //: ICrud<Employee>
    {
        List<Employee> Get();
        Employee Get(string id);
        Employee Create(Employee employee);
        void Update(string id, Employee employee);
        void Remove(string id);

    }
}
