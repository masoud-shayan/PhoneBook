using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PhoneBook.Application.DTO;
using PhoneBook.Application.Mapper.DTOMapper;
using PhoneBook.Application.Query;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.QueryHandler
{
    public class GetContactsByTagQueryHandler : IRequestHandler<GetContactsByTagQuery, IList<ContactDTO>>
    {
        private readonly IContactQueryRepository _contactQueryRepository;

        public GetContactsByTagQueryHandler(IContactQueryRepository contactQueryRepository)
        {
            _contactQueryRepository = contactQueryRepository;
        }

        public async Task<IList<ContactDTO>> Handle(GetContactsByTagQuery request, CancellationToken cancellationToken)
        {
            return _contactQueryRepository.GetByTag(request.Tag).ToList().ToDTO();
        }
    }
}