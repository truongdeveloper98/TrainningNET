using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainning.Core.ViewModels.Authentications;
using Trainning.Service.Authentication;

namespace Trainning.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<string> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
