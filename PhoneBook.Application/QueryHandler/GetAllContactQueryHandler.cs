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
    public class GetAllContactQueryHandler : IRequestHandler< GetAllContactQuery , IList<ContactDTO> >
    {
        private readonly IContactQueryRepository _contactQueryRepository;

        public GetAllContactQueryHandler(IContactQueryRepository contactQueryRepository)
        {
            _contactQueryRepository = contactQueryRepository;
        }

        public async Task<IList<ContactDTO>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            return _contactQueryRepository.GetAll().ToList().ToDTO();
        }
    }
}