using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class CartItem
    {
		public string Id { get; set; }
		public string CartId { get; set;}
		[ForeignKey("CarId")]
		public Cart Cart { get; set; }

		public string ProductId { get; set; }
		[ForeignKey("ProduId")]
		public Product Product { get; set; }
		public int Qantity { get; set; }
		[NotMapped]
		public decimal TotalPrice
		{
			get
			{
				return Product.Price * Qantity;
			}
		}
    }
}
