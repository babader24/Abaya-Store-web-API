using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.ShippingInfo
{
	public class ShippingInfoDto
	{
		public int Id { get; set; }
		public int BillId { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public byte DeliveryStatus { get; set; }
	}
	public class ShippingInfoListDto
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public byte DeliveryStatus { get; set; }
	}
	public class ShippingInfoCreateDto
	{
		public int BillId { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public byte DeliveryStatus { get; set; }
	}

	public class ShippingInfoUpdateDto
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public byte DeliveryStatus { get; set; }
	}

}
