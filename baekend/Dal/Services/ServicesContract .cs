using Dal.Interface;
using Dal.Entities;
using MongoDB.Driver;


namespace Dal.Services
{
    public class ServicesContract : IServicesContract
    {
        private readonly IMongoCollection<Contract> _contracts;

        public ServicesContract(IDataBaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _contracts = database.GetCollection<Contract>(settings.CollectionContract);
        }
        public async Task<Contract> Create(Contract contract)
        {
            _contracts.InsertOne(contract);
            return null;
        }

        public async Task<List<Contract>> Get()
        {
            var x = _contracts.Find(contracts => true).ToList();
            return x;
        }

        public async Task<Contract> Get(string id)
        {
            return _contracts.Find(contracts => contracts.Id == id).FirstOrDefault();
        }

        public async Task Remove(string id)
        {
            _contracts.DeleteOne(contracts => contracts.Id == id);
        }

        public async Task Update(string id, Contract contract)
        {
            _contracts.ReplaceOne(contracts => contracts.Id == id, contract);
        }


    }

}