using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class UserService : IUserService
	{
		private readonly IRepository<User> _userRepo;
		private readonly IMapper _mapper;

		public UserService(IRepository<User> userRepo, IMapper mapper)
		{
			_userRepo = userRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<User>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<User?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<User> CreateAsync(User user)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, User user)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
