using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Command;
using PhoneBook.Application.DTO;
using PhoneBook.Application.Query;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;

namespace PhoneBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PhoneBookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ContactDTO>> CreateContactAsync([FromBody] CreateContactCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.ValidationState);
                }
            
                var commandResult = await _mediator.Send(command);
            
                if (commandResult is null)
                {
                    return BadRequest();
                }
            
                return commandResult;
            }
            catch
            {
                return BadRequest();
            }

        }
        
        
        [HttpPut]
        public async Task<IActionResult> UpdateContactAsync([FromBody] UpdateContactCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.ValidationState);
                }
            
                await _mediator.Send(command);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteContactAsync(int contactId)
        {
            try
            {
                await _mediator.Send(new DeleteContactCommand(contactId));

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            try
            {
                var contacts = await _mediator.Send(new GetAllContactQuery());
                return Ok(contacts);
            }
            catch
            {
                return NotFound();
            }
        }
        
        [HttpGet("{tag}")]   
        public async Task<IActionResult> GetByTag(string tag)
        {

            try
            {
                var contacts = await _mediator.Send(new GetContactsByTagQuery(tag));
                return Ok(contacts);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}