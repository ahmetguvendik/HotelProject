using System;
namespace Hotel.Frontend.Models.Booking
{
	public class CreateBookingViewModel
	{
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; }
        public string Statues { get; set; }
    }
}

