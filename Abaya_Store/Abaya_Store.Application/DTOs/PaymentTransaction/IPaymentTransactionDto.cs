namespace Abaya_Store.Application.DTOs.PaymentTransaction
{
	public interface IPaymentTransactionDto
	{
		public int BillId { get; set; }
		public string PaymentGateway { get; set; }
		public string TransactionId { get; set; }
		public decimal Amount { get; set; }
		public bool IsSuccess { get; set; }
		public string? ResponseMessage { get; set; }
	}

}
