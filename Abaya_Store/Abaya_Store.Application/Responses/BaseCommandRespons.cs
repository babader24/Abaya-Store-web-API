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
		public bool IsSuccess { get; set; }
		public string Message { get; set; } 
		public List<string>? Errors { get; set; }

		public  BaseCommandRespons Success(int id, string massage = "creation success" )
		{
			return new BaseCommandRespons
			{
				IsSuccess = true,
				Message = massage,
				Id = id,
				Errors = null
			};
		}
		public BaseCommandRespons Failure(List<string> errors, string massage = "creation failed")
		{
			return new BaseCommandRespons
			{
				IsSuccess = false,
				Message = massage,
				Id = 0,
				Errors = errors
			};
		}
	}
}
