using Abaya_Store.Services.Interfaces;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class PaymentTransactionService : IPaymentTransactionService
	{
		private readonly IRepository<PaymentTransaction> _paymentTransactionRepo;
		private readonly IMapper _mapper;

		public PaymentTransactionService(IRepository<PaymentTransaction> paymentTransactionRepo, IMapper mapper)
		{
			_paymentTransactionRepo = paymentTransactionRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<PaymentTransaction>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<PaymentTransaction?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<PaymentTransaction> CreateAsync(PaymentTransaction paymentTransaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, PaymentTransaction paymentTransaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
