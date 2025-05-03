using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.AuditLog
{
	public class AuditLogDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Action { get; set; }
		public DateTime Date { get; set; }

		public string? UserFullName { get; set; }
	}
	public class CreateAuditLogDto
	{
		public int UserId { get; set; }
		public string Action { get; set; } 
	}
}
