using JwtAuthenticationDemo.Shared;
using System.Threading.Tasks;

namespace JwtAuthenticationDemo.Client.Services
{
    interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
