using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Bill
{
    public interface IBillDto
	{
		public string BillNumber { get; set; }
		public int CustomerId { get; set; }
		public decimal Total { get; set; }
		public string Notes { get; set; }
		public byte PaymentStatus { get; set; }
	}
}
