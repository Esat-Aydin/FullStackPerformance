using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drivers.api.Configurations;
using Drivers.api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Drivers.api.Services
{
    public class DriverService
    {
        private readonly AppDbContext _context;
        private readonly DatabaseSettings _dbSettings;

        public DriverService(AppDbContext context, IOptions<DatabaseSettings> dbSettings)
        {
            _context = context;
            _dbSettings = dbSettings.Value;
        }

        public async Task<List<Driver>> GetDriversAsync()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<Driver> GetDriverAsync(int id)
        {
            return await _context.Drivers.FindAsync(id) ?? throw new InvalidOperationException($"Driver with ID {id} not found.");
        }

        public async Task<Driver> AddDriverAsync(Driver driver)
        {
            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver> UpdateDriverAsync(Driver driver)
        {
            _context.Drivers.Update(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver> DeleteDriverAsync(int id)
        {
            var driver = await _context.Drivers.FindAsync(id) ?? throw new InvalidOperationException($"Driver with ID {id} not found.");
            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<bool> IsDriverExistsAsync(string id)
        {
            return await _context.Drivers.AnyAsync(d => d.Id == id);
        }
    }

}