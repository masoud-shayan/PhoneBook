using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PhoneBook.Application.Command;
using PhoneBook.Application.Command;
using PhoneBook.Application.DTO;
using PhoneBook.Application.Mapper;
using PhoneBook.Application.Mapper.DTOMapper;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.CommandHandler
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, ContactDTO>
    {
        private readonly IContactRepository _contactRepository;
        
        public CreateContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public async Task<ContactDTO> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = new Contact(request.Name.ToName() , request.Tag , request.NumberTypeId , request.Number , request.Email , request.Website);
            var newContact = _contactRepository.Add(contact);
            await _contactRepository.UnitOfWork.SaveChangesAsync();

            return newContact.ToDTO();

        }
    }
}