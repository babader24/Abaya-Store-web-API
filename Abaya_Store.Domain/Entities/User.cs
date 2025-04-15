namespace Abaya_Store.Domain.Entities
{
	public class User : Person
	{
		public string UserName { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime? LastLogin { get; set; }
		public string Position { get; set; } 
		public byte Permissions { get; set; }

		public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
	}
}
