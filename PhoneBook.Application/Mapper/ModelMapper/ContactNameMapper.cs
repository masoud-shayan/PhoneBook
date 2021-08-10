using PhoneBook.Application.Command;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.Mapper
{
    public static class ContactNameMapper 
    {
        public static  Name ToName(this ContactName contactName)
        {
            return new Name(contactName.FirstName, contactName.LastName);
        }
    }
}