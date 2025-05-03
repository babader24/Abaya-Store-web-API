using Abaya_Store.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Contracts.Infrastructture
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email); 
    }
}
