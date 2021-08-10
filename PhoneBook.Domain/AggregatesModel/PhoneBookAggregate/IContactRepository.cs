using System.Threading.Tasks;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Domain.AggregatesModel.PhoneBookAggregate
{
    public interface IContactRepository : IRepository<Contact>
    {
        Contact Add(Contact contact);
        
        void Update(Contact contact);
        
        void Delete(Contact contact);
        Contact GetById(int phoneBookId);
        
        string GetByAll();
    }
}