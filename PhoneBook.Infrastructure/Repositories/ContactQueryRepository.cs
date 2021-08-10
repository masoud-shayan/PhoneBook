using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Infrastructure.Repositories
{
    public class ContactQueryRepository : IContactQueryRepository
    {
        private readonly Context<Contact> _context;
        public IUnitOfWork UnitOfWork => _context;

        public ContactQueryRepository(Context<Contact> context)
        {
            _context = context;
        }
        
        
        public IEnumerable<Contact> GetByTag(string tag)
        {
            return _context.GetByTag(tag);
        }
        
        public IEnumerable<Contact> GetAll()
        {
            return _context.GetAll();
        }


        
        
    }
}