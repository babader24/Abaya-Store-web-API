﻿using Abaya_Store.Application.Contracts.Infrastructture;
using Abaya_Store.Application.Model.Email;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Infrastructure.Mail
{
	public class EmailSender : IEmailSender
	{
		private  EmailSettings _emailSettings { get; }

		public EmailSender(IOptions<EmailSettings> emailSettings )
		{
			_emailSettings = emailSettings.Value;
		}
		public async Task<bool> SendEmail(Email email)
		{
			var clint = new SendGridClient(_emailSettings.ApiKey);
			var to = new EmailAddress(email.To);
			var from = new EmailAddress
			{
				Email = _emailSettings.FromAddress,
				Name = _emailSettings.FromName
			};

			var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
			var response = await clint.SendEmailAsync(message);

			return response.StatusCode == System.Net.HttpStatusCode.OK ||
				response.StatusCode == System.Net.HttpStatusCode.Accepted;
		}
	}
}
