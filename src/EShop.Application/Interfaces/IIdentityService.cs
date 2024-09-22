using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using EShop.Shared.ResponseModels.Identity;

namespace EShop.Application.Interfaces;

public interface IIdentityService
{
    Task<ServiceResult> ConfirmEmail(string email, string code);
    Task<ManageInfoResponse> ManageInfo(string jwtToken);
    Task<ServiceResult> Register(string userName, string email, string password);
    Task<ServiceResult> SignIn(string email, string password, bool lockoutOnFailure);
    Task<string> GenerateEmailConfirmationToken(string email);
    Task<ServiceResult> ResetPassword(string email, string resetCode, string newPassword);
    Task<ServiceResult> ForgotPassword(string email);
    Task<ServiceResult> Manage2Fa();
    Task<string> GenerateJwtToken(string email);
    Task<bool> CheckExistUserByEmailAsync(string email);
    Task<string> RefreshToken(string oldToken);
}