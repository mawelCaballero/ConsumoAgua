using ConsumoAgua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumoAgua.Services
{
    public class MockDataStore : IDataStore<Consumption>
    {
        List<Consumption> items;

        public MockDataStore()
        {
            items = new List<Consumption>();
            var mockItems = new List<Consumption>
            {
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 01) ,CubicLiters = 408 ,  Description="This is an item description." },
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 03), CubicLiters = 414 ,  Description="This is an item description." },
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 10), CubicLiters = 421 ,  Description="This is an item description." },
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 17), CubicLiters = 433 ,  Description="This is an item description." },
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 24), CubicLiters = 439 ,  Description="This is an item description." },
                new Consumption { Id = Guid.NewGuid().ToString(), Date = new DateTime(2019, 08, 31), CubicLiters = 452 ,  Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Consumption item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Consumption item)
        {
            var oldItem = items.Where((Consumption arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Consumption arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Consumption> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Consumption>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}