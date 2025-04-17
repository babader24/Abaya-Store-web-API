using Abaya_Store.Application.DTOs.AuditLog;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
    public class AuditLogProfile : Profile
    {
		public AuditLogProfile()
		{
			// من الكيان إلى DTO للعرض
			CreateMap<AuditLog, AuditLogDto>()
				.ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => src.User != null ? $"{src.User.FirstName} {src.User.LastName}" : null));

			// من DTO للإضافة إلى الكيان
			CreateMap<CreateAuditLogDto, AuditLog>();
		}

	}
}
