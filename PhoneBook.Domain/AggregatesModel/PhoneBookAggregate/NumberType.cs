using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Domain.AggregatesModel.PhoneBookAggregate
{
    public class NumberType : Enumeration
    {
        public static NumberType Landline  = new NumberType(1, nameof(Landline).ToLowerInvariant());
        public static NumberType Mobile = new NumberType(2, nameof(Mobile).ToLowerInvariant());
        public static NumberType Virtual = new NumberType(3, nameof(Virtual).ToLowerInvariant());

        public NumberType(int id, string name) : base(id, name)
        {
        }
    }
}