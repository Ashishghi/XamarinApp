using System;
using SQLite;

namespace XamarinApp.Model
{
	public class ProductInfo
	{
		[PrimaryKey, AutoIncrement]
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}

