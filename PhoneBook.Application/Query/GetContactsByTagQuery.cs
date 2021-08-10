using System.Collections.Generic;
using MediatR;
using PhoneBook.Application.DTO;

namespace PhoneBook.Application.Query
{
    public class GetContactsByTagQuery : IRequest<IList<ContactDTO>>
    {
        public string Tag { get; set; }

        public GetContactsByTagQuery(string tag)
        {
            Tag = tag;
        }
    }
}