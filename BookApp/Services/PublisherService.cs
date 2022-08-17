using BookApp.Data;
using BookApp.Interfaces;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading.Tasks;

namespace BookApp.Services
{
    public class PublisherService : IPublisherService
    {
        public BookAppDbContext _bookAppDBContext; 

        public PublisherService()
        {
        }

        public Task<int> Count(string search)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Create(Publisher publisher)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Publisher> GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Publisher>> ListAll(int skip, int take, string orderBy, string direction, string search)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Update(Publisher publisher)
        {
            throw new System.NotImplementedException();
        }
    }
}
