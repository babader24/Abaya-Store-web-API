using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class OfferProductService : IOfferProductService
	{
		private readonly IRepository<OfferProduct> _offerProductRepo;
		private readonly IMapper _mapper;

		public OfferProductService(IRepository<OfferProduct> offerProductRepo, IMapper mapper)
		{
			_offerProductRepo = offerProductRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<OfferProduct>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<OfferProduct?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<OfferProduct> CreateAsync(OfferProduct offerProduct)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, OfferProduct offerProduct)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
