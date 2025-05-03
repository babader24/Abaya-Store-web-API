using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.NewsletterSubscription.Validator
{
	public class INewsletterSubscriptionDtoValidator : AbstractValidator<INewsletterSubscriptionDto>
	{
		public INewsletterSubscriptionDtoValidator()
		{
			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.EmailAddress().WithMessage("{PropertyName} must be a valid email.")
				.MaximumLength(100);
		}
	}
}
