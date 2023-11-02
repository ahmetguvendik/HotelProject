using System;
using MediatR;

namespace Hotel.Application.CQRS.Commands.Subscribe.CreateSubscribe
{
	public class CreateSubscribeCommandRequest : IRequest<CreateSubscribeCommandResponse>
	{
		public string Email { get; set; }	
	}
}

