using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using MongoDB.Driver;
using Dal.Interface;


namespace Dal.Services
{
    public class ServicesEmployee : IServicesEmployee
    {
        private readonly IMongoCollection<Employee> _employees;

        public ServicesEmployee(IDataBaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _employees = database.GetCollection<Employee>(settings.CollectionEmployee);
        }
        public async Task<Employee> Create(Employee employee)
        {
            _employees.InsertOne(employee);
            return null;
        }

        public async Task<List<Employee>> Get()
        {
            var x = _employees.Find(employees => true).ToList();
            return x;
        }

        public async Task<Employee> Get(string id)
        {
            return _employees.Find(employees => employees.Id == id).FirstOrDefault();
        }

        public async Task Remove(string id)
        {
            _employees.DeleteOne(employees => employees.Id == id);
        }

        public async Task Update(string id, Employee employee)
        {
            _employees.ReplaceOne(employees => employees.Id == id, employee);
        }


    }

}