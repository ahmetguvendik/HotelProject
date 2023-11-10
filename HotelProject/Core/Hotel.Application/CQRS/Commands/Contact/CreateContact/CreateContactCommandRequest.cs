using System;
using MediatR;

namespace Hotel.Application.CQRS.Commands.Contact.CreateContact
{
	public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}

