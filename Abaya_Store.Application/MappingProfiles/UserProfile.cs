using Abaya_Store.Application.DTOs.User;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, UserListDto>()
				.ForMember(dest => dest.FullName, opt =>
					opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

			CreateMap<User, UserDto>()
				.ForMember(dest => dest.AuditActions, opt =>
					opt.MapFrom(src => src.AuditLogs.Select(a => a.Action).ToList()));

			CreateMap<UserCreateDto, User>();
			CreateMap<UserUpdateDto, User>();
		}
	}

}
