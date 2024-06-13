using Trainning.Core.ViewModels.Authentications;

namespace Trainning.Service.Authentication
{
    public interface IAuthenticationService
    {
        Task<string> Login(LoginViewModel model);
    }
}
