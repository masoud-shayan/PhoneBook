using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediatR;
using PhoneBook.Application.DTO;

namespace PhoneBook.Application.Command
{
    public class CreateContactCommand : IRequest<ContactDTO>
    {
        [Required]
        public ContactName Name { get;  set; }
        [Required]
        public string Tag { get;  set; }
        [Required]
        [Range(1,3)]
        public int NumberTypeId { get;  set; }
        [Required]
        [Phone]
        public string Number { get;  set; }
        [EmailAddress]
        public string Email { get;  set; }
        [Url]
        public string Website { get;  set; }
    }

    public class ContactName
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
    }
}