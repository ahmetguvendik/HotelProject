using System;
namespace Hotel.Domain.Entities
{
	public class Service : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string IconPath { get; set; }	
	}
}

