using System.Collections.Generic;
using MediatR;
using PhoneBook.Application.DTO;

namespace PhoneBook.Application.Query
{
    public class GetAllContactQuery : IRequest<IList<ContactDTO>>
    {
        
    }
}