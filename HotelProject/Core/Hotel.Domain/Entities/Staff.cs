using System;
namespace Hotel.Domain.Entities
{
	public class Staff : BaseEntity
	{
		public string FullName { get; set; }
		public string PersonTitle { get; set; }
		public string ImagePath { get; set; }	
		public string TwitterLink { get; set; }
		public string FacebookLink { get; set; }
		public string InstagramLink { get; set; }
	}
}

