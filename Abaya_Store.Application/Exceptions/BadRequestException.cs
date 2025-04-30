using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Exceptions
{
	public class BadRequestException : ApplicationException
    {
		public BadRequestException(string message) : base(message)
		{
			
		}
	}
}
