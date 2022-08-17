using System.Collections.Generic;
using System.Security.Policy;
using System.Threading.Tasks;

namespace BookApp.Interfaces
{
    public interface IPublisherService
    {
        Task<int> Create(Publisher publisher);

        Task<int> Delete(int Id);

        Task<int> Count(string search);

        Task<int> Update(Publisher publisher);

        Task<Publisher> GetById(int Id);

        Task<List<Publisher>> ListAll(int skip, int take, string orderBy, string direction, string search);
    }
}
