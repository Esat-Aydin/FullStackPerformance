using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drivers.api.Configurations;
using Drivers.api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Drivers.api.Services
{
    public class DriverService
    {
        private readonly IMongoCollection<Driver> _driverCollection;

        public DriverService(IOptions<DatabaseSettings> databasesettings)
        {
            // initiliaze  
            var mongoClient = new MongoClient(databasesettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databasesettings.Value.DatabaseName);

            _driverCollection = mongoDatabase.GetCollection<Driver>(databasesettings.Value.CollectionName);
        }
        public async Task<List<Driver>> GetAllDriversAsync() =>
            await _driverCollection.Find(_ => true).ToListAsync();
    }

}