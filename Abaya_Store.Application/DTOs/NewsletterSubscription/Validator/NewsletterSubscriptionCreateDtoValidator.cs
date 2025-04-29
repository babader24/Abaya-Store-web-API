using FluentValidation;

namespace Abaya_Store.Application.DTOs.NewsletterSubscription.Validator
{
	public class NewsletterSubscriptionCreateDtoValidator : AbstractValidator<NewsletterSubscriptionCreateDto>
	{
		public NewsletterSubscriptionCreateDtoValidator()
		{
			Include(new INewsletterSubscriptionDtoValidator());
		}
	}

}
