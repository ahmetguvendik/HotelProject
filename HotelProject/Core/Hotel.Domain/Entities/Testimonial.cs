using System;
namespace Hotel.Domain.Entities
{
	public class Testimonial : BaseEntity
	{
		public string Description { get; set; }
		public string PersonInfo { get; set; }
		public string PersonTitle { get; set; }	
	}
}

