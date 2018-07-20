using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Cart
    {
		public string Id { get; set; }
		public string Owner { get; set; }
		public virtual ICollection<CartItem> CarItems { get; set; }
		
		public string CreateBy { get; set; }
		public DateTime CreateData { get; set; }
		public string UpdateBy { get; set;}
		public DateTime UpdateData { get; set; }

		public bool IsActive { get; set; }
    }
}
