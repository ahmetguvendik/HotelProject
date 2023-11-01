using System;
namespace Hotel.Frontend.Models.About
{
	public class GetAboutViewModel
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int ClientCount { get; set; }
    }
}

