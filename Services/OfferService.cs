using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class OfferService : IOfferService
	{
		private readonly IRepository<Offer> _offerRepo;
		private readonly IMapper _mapper;

		public OfferService(IRepository<Offer> offerRepo, IMapper mapper)
		{
			_offerRepo = offerRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Offer>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Offer?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Offer> CreateAsync(Offer offer)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Offer offer)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
