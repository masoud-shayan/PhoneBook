using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PhoneBook.Application.Command;
using PhoneBook.Application.Mapper;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.CommandHandler
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand , Unit>
    {
        private readonly IContactRepository _contactRepository;

        public UpdateContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<Unit> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
           var contact =  _contactRepository.GetById(request.Id);
           if (contact is not null)
           {
               contact.UpdateContact(request.Name.ToName() , request.Tag , request.NumberTypeId , request.Number , request.Email , request.Website);
           
               _contactRepository.Update(contact);
               await _contactRepository.UnitOfWork.SaveChangesAsync();
           }

           return Unit.Value;
        }
        
    }
}