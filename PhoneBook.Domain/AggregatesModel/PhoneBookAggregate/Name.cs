using System.Collections.Generic;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Domain.AggregatesModel.PhoneBookAggregate
{
    public class Name : ValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}