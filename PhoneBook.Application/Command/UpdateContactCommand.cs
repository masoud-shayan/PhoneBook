using System.ComponentModel.DataAnnotations;
using MediatR;
using PhoneBook.Application.DTO;

namespace PhoneBook.Application.Command
{
    public class UpdateContactCommand : IRequest
    {
        [Required]
        public int Id { get; set; }
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
}