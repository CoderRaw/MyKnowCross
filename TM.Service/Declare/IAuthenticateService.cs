using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Service.Declare
{
   public interface IAuthenticateService
    {
        bool IsTechnicianAuthenticated(string username, string password);
    }
}
