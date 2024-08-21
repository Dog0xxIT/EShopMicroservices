using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using EShop.Application.Dto;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IIdentityService
{
    Task<ServiceResult<int>> ConfirmEmail(string email, string code);
    Task<ServiceResult<int>> ManageInfo();
    Task<ServiceResult<int>> Register(string userName, string email, string password);
    Task<ServiceResult<string>> SignIn(string email, string password, bool lockoutOnFailure);
    Task<string> GenerateEmailConfirmationToken(string email);
    Task<ServiceResult<int>> ResetPassword(string email, string resetCode, string newPassword);
    Task<ServiceResult<int>> ForgotPassword(string email);
    Task<ServiceResult<int>> Manage2Fa();
    string GenerateJwtToken(List<Claim> claims);
    ServiceResult<string> RefreshToken(string oldToken);
    Task<bool> CheckExistUserByEmailAsync(string email);
}