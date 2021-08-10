using System.Collections.Generic;
using System.Threading.Tasks;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Domain.AggregatesModel.PhoneBookAggregate
{
    public interface IContactQueryRepository : IRepository<Contact>
    {
        IEnumerable<Contact> GetByTag(string tag);
        IEnumerable<Contact> GetAll();
    }
}