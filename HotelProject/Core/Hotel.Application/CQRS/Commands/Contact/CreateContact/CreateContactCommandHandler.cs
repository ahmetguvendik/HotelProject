using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Commands.Contact.CreateContact
{
	public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest,CreateContactCommandResponse>
	{
        private readonly IContactWriteRepository _contactWriteRepository;
		public CreateContactCommandHandler(IContactWriteRepository contactWriteRepository)
		{
            _contactWriteRepository = contactWriteRepository;
		}

        public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            var contact = new Domain.Entities.Contact();
            contact.Id = Guid.NewGuid().ToString();
            contact.Name = request.Name;
            contact.Email = request.Email;
            contact.Subject = request.Subject;
            contact.Message = request.Message;
            await _contactWriteRepository.AddAsync(contact);
            await _contactWriteRepository.SaveAsync();
            return new CreateContactCommandResponse();
        }
    }
}

