using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Responses
{
    public class BaseCommandRespons
    {
		public int Id { get; set; }
		public bool Succsss { get; set; }
		public string Message { get; set; } 
		public List<string> Errors { get; set; }
	}
}
