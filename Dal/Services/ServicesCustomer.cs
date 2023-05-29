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
    public class ServicesCustomer : IServicesCustomer
    {
        private readonly IMongoCollection<Customer> _customers;

        public ServicesCustomer(IDataBaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _customers = database.GetCollection<Customer>(settings.CollectionCustomer);
        }
        public async Task<Customer> Create(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public async Task<List<Customer>> Get()
        {
            var x = _customers.Find(customers => true).ToList();
            return x;
        }

        public async Task<Customer> Get(string id)
        {
            return _customers.Find(customers => customers.Id == id).FirstOrDefault();
        }

        public async Task Remove(string id)
        {
            _customers.DeleteOne(customers => customers.Id == id);
        }

        public async Task Update(string id, Customer customer)
        {
            _customers.ReplaceOne(customers => customers.Id == id, customer);
        }


    }

}