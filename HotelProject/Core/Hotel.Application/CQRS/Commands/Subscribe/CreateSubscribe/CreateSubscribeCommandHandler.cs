using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Commands.Subscribe.CreateSubscribe
{
	public class CreateSubscribeCommandHandler : IRequestHandler<CreateSubscribeCommandRequest,CreateSubscribeCommandResponse>
	{
        private readonly ISubscribeWriteRepository _subscribeWriteRepository;
		public CreateSubscribeCommandHandler(ISubscribeWriteRepository subscribeWriteRepository)
		{
            _subscribeWriteRepository = subscribeWriteRepository;
		}

        public async Task<CreateSubscribeCommandResponse> Handle(CreateSubscribeCommandRequest request, CancellationToken cancellationToken)
        {
            var subscribe = new Domain.Entities.Subscribe();
            subscribe.Id = Guid.NewGuid().ToString();
            subscribe.Email = request.Email;
            await _subscribeWriteRepository.AddAsync(subscribe);
            await _subscribeWriteRepository.SaveAsync();
            return new CreateSubscribeCommandResponse();
        }
    }
}

