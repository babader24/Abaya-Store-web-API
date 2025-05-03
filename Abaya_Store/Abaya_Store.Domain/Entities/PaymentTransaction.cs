namespace Abaya_Store.Domain.Entities
{
	public class PaymentTransaction
	{
		public int Id { get; set; }
		public int BillId { get; set; } // FK to Bill
		public string PaymentGateway { get; set; } // مثل "PayPal", "Stripe", "HyperPay"
		public string TransactionId { get; set; } // من بوابة الدفع
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public string? ResponseMessage { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;

		public virtual Bill Bill { get; set; }
	}
}
