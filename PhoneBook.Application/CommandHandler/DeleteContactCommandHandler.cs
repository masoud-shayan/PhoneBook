using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PhoneBook.Application.Command;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.Application.CommandHandler
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, Unit>
    {
        private readonly IContactRepository _contactRepository;

        public DeleteContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public Task<Unit> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = _contactRepository.GetById(request.Id);
            if (contact is not null)
            {
                _contactRepository.Delete(contact);
                _contactRepository.UnitOfWork.SaveChangesAsync();
            }

            return Unit.Task;
        }
    }
}