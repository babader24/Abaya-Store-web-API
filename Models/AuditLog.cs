namespace AbayaStore.Models
{
	public class AuditLog
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Action { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;

		public virtual User User { get; set; }
	}
}
