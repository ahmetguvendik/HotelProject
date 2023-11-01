using System;
namespace Hotel.Frontend.Models.Room
{
	public class GetRoomViewModel
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int BadCount { get; set; }
        public int BathCount { get; set; }
        public string ImagePath { get; set; }
    }
}

