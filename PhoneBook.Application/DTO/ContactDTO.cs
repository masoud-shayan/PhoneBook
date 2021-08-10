using System;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.DTO
{
    public class ContactDTO
    {
        public int Id { get; set; }

        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Name Name { get; set; }

        public string Tag { get; set; }

        public NumberType NumberType { get; set; }

        public string Number { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}