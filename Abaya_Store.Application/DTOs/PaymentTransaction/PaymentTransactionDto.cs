using Abaya_Store.Application.DTOs.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.PaymentTransaction
{
	public class PaymentTransactionDto
	{
		public int Id { get; set; }
		public int BillId { get; set; }
		public string PaymentGateway { get; set; }
		public string TransactionId { get; set; }
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public string? ResponseMessage { get; set; }
		public DateTime Date { get; set; }

		public BillDto Bill { get; set; } // تفاصيل الفاتورة المرتبطة بالمعاملة
	}
	public class PaymentTransactionCreateDto
	{
		public int BillId { get; set; }
		public string PaymentGateway { get; set; }
		public string TransactionId { get; set; }
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public string? ResponseMessage { get; set; }
	}

	public class PaymentTransactionUpdateDto
	{
		public int Id { get; set; }
		public int BillId { get; set; }
		public string PaymentGateway { get; set; }
		public string TransactionId { get; set; }
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public string? ResponseMessage { get; set; }
	}

	public class PaymentTransactionListDto
	{
		public int Id { get; set; }
		public int BillId { get; set; }
		public string PaymentGateway { get; set; }
		public string TransactionId { get; set; }
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public DateTime Date { get; set; }
	}

}
