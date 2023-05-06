using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using MongoDB.Driver;

namespace Dal.Services
{
    public class ServicesEmployee : IServicesEmployee
    {
        private readonly IMongoCollection<Employee> _employees;

        public ServicesEmployee(IDataBaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _employees = database.GetCollection<Employee>(settings.CollectionName);
        }
        public Employee Create(Employee employee)
        {
            _employees.InsertOne(employee);
            return employee;
        }

        public List<Employee> Get()
        {
            return _employees.Find(employees => true).ToList();
        }

        public Employee Get(string id)
        {
            return _employees.Find(employees => employees.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _employees.DeleteOne(employees => employees.Id == id);
        }

        public void Update(string id, Employee employee)
        {
            _employees.ReplaceOne(employees => employees.Id == id, employee);
        }

       
    }
}
