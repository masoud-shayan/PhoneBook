using System.Collections.Generic;
using System.Linq;
using PhoneBook.Application.DTO;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.Mapper.DTOMapper
{
    public static class CreateContactDTOMapper
    {
        public static ContactDTO ToDTO(this Contact contact)
        {
            return new ContactDTO
            {
                Id = contact.Id ,
                CreateDateTime = contact.CreateDateTime,
                UpdatedTime = contact.UpdatedTime,
                Name = contact.Name,
                Tag = contact.Tag,
                NumberType = contact.NumberType,
                Number = contact.Number,
                Email = contact.Email,
                Website = contact.Website
            };
        }

        public static List<ContactDTO> ToDTO(this IList<Contact> contacts)
        {
            return contacts.Select(x => x.ToDTO()).ToList();
        }
    }
}