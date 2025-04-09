namespace Abaya_Store.Services.Interfaces
{
	public interface IPaymentTransactionService
	{
		Task<IEnumerable<PaymentTransaction>> GetAllAsync();
		Task<PaymentTransaction?> GetByIdAsync(int id);
		Task<PaymentTransaction> CreateAsync(PaymentTransaction transaction);
		Task<bool> UpdateAsync(PaymentTransaction transaction);
		Task<bool> DeleteAsync(int id);
	}
}
