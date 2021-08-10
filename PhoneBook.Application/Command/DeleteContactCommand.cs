using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediatR;
using PhoneBook.Application.DTO;

namespace PhoneBook.Application.Command
{
    public class DeleteContactCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteContactCommand(int id)
        {
            Id = id;
        }
    }
    
    
}