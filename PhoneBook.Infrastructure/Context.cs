using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using PhoneBook.Domain.SeedWork;
using PhoneBook.Infrastructure.Repositories;

namespace PhoneBook.Infrastructure
{
    public class Context<T>  : IUnitOfWork  , IOurContext<T>  where T : Entity
    {
        private static List<T> _dbSet;

        public T Add(T item) 
        {
            if (_dbSet is null)
            {
                _dbSet = new List<T>();
            }
            
            _dbSet.Add(item);

            return item;
        }

        public void Update(T item) 
        {
            if (_dbSet is not null)
            {
                var contactIndex = _dbSet.FindIndex(x => x.Id == item.Id);
                if (contactIndex != -1) Replace(_dbSet, contactIndex, item);
            }
        }

        public void Delete(T item)
        {
            if (_dbSet is not null)
            {
                var contactIndex = _dbSet.FindIndex(x => x.Id == item.Id);
                if (contactIndex != -1) Delete(_dbSet, contactIndex);
            }
        }

        public T Get(int contactId) 
        {
            return _dbSet.Find(x => x.Id == contactId);
        }


        public IEnumerable<T> GetByTag(string tag)
        {
            var y = typeof(T).GetProperty("Tag");
            
            return _dbSet.Where(x => y.GetValue(x).ToString().Equals($@"#{tag}"));;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }


        public void Dispose()
        {
            Console.WriteLine("Disposing Unmanaged Resources .......");
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Saving the _dbSet   .......");
            return 1;
        }


        private static void Replace(IList<T> list, int index, T secondList)
        {
            list[index] = secondList;
        }

        private static void Delete(IList<T> list, int index)
        {
            list.RemoveAt(index);
        }
    }
}