using System.Threading.Tasks;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context<Contact> _context;
        public IUnitOfWork UnitOfWork => _context;
        
        
        public ContactRepository(Context<Contact> context)
        {
            _context = context;
        }


        public Contact Add(Contact contact)
        {
            return _context.Add(contact);
        }
        
        public void Update(Contact contact)
        {
            _context.Update(contact);
        }
        
        public void Delete(Contact contact)
        {
            _context.Delete(contact);
        }
        
        public Contact GetById(int phoneBookId)
        {
            return  _context.Get(phoneBookId);
        }

        public string GetByAll()
        {
            return "salam";
        }
    }
}