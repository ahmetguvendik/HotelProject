using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Commands.Booking.CreateBooking
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommandRequest, CreateBookingCommandResponse>
	{
        private readonly IBookingWriteRepository _bookingWriteRepository;
		public CreateBookingCommandHandler(IBookingWriteRepository bookingWriteRepository)
		{
            _bookingWriteRepository = bookingWriteRepository;
		}

        public async Task<CreateBookingCommandResponse> Handle(CreateBookingCommandRequest request, CancellationToken cancellationToken)
        {
            var booking = new Domain.Entities.Booking();
            booking.Id = Guid.NewGuid().ToString();
            booking.Name = request.Name;
            booking.Email = request.Email;
            booking.Description = request.Description;
            booking.CheckIn = request.CheckIn;
            booking.CheckOut = request.CheckOut;
            booking.ChildCount = request.ChildCount;
            booking.AdultCount = request.AdultCount;
            booking.RoomCount = request.RoomCount;
            booking.Statues = "Onay Bekliyor";
            await _bookingWriteRepository.AddAsync(booking);
            await _bookingWriteRepository.SaveAsync();
            return new CreateBookingCommandResponse();
        }
    }
}

