using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using MongoDB.Driver;


namespace Dal.Services
{
    public class ServicesCustomer : ICrud<Customer>
    {
        private readonly IMongoCollection<Customer> _customers;

        public ServicesCustomer(IDataBaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _customers = database.GetCollection<Customer>(settings.CollectionCustomer);
        }
        public Customer Create(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public List<Customer> Get()
        {
            return _customers.Find(customers => true).ToList();
        }

        public Customer Get(string id)
        {
            return _customers.Find(customers => customers.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _customers.DeleteOne(customers => customers.Id == id);
        }

        public void Update(string id, Customer customer)
        {
            _customers.ReplaceOne(customers => customers.Id == id, customer);
        }

       
    }

}