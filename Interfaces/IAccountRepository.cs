using Microsoft.AspNetCore.Identity;
using WeatherAPI.Models;

namespace WeatherAPI.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
