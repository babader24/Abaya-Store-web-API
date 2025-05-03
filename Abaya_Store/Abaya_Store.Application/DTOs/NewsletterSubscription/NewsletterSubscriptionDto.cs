using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.NewsletterSubscription
{
	public class NewsletterSubscriptionDto
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public DateTime SubscribedAt { get; set; }
		public bool IsActive { get; set; }

		public string? CustomerFullName { get; set; }
	}
	public class NewsletterSubscriptionListDto
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public DateTime SubscribedAt { get; set; }
	}
	public class NewsletterSubscriptionUpdateDto 
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
	}
	public class NewsletterSubscriptionCreateDto : INewsletterSubscriptionDto
	{
		public int? CustomerId { get; set; }
		public string Email { get; set; }
	}

}
