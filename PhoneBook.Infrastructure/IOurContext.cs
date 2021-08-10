using System.Collections.Generic;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Infrastructure.Repositories
{
    public interface IOurContext<T> where T : Entity
    {
        T Add(T item);
        void Update(T item);
        void Delete(T item);
        T Get(int i);
        IEnumerable<T> GetByTag(string tag);
        IEnumerable<T> GetAll();
    }
}