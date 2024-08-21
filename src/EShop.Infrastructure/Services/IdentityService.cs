using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EShop.Application.Configurations;
using EShop.Application.Constants;
using EShop.Application.Dto;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace EShop.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly ILogger<IdentityService> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly JwtConfig _jwtConfig;
        private readonly IEmailSenderService _emailSenderService;

        public IdentityService(ILogger<IdentityService> logger, UserManager<User> userManager, IEmailSenderService emailSenderService, SignInManager<User> signInManager, JwtConfig jwtConfig)
        {
            _logger = logger;
            _userManager = userManager;
            _emailSenderService = emailSenderService;
            _signInManager = signInManager;
            _jwtConfig = jwtConfig;
        }

        public string GenerateJwtToken(List<Claim> claims)
        {
            var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
            var signingCredentials = new SigningCredentials(signKey, _jwtConfig.Algorithm);
            var optionsHeader = new Dictionary<string, string>
            {
                ["alg"] = signingCredentials.Algorithm,
                ["typ"] = JwtConstants.TokenType
            };
            var header = new JwtHeader(signingCredentials, optionsHeader);

            var payload = new JwtPayload(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                expires: DateTime.UtcNow.AddDays(Convert.ToInt64(_jwtConfig.Expires)),
                notBefore: DateTime.UtcNow,
                claims: claims);

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(new JwtSecurityToken(header, payload));

            return token;
        }

        public ServiceResult<string> RefreshToken(string oldToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckExistUserByEmailAsync(string email)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            return userEntity != null;
        }

        public async Task<ServiceResult<int>> ConfirmEmail(string email, string code)
        {
            var serviceResult = new ServiceResult<int>();

            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity is null)
            {
                return new ServiceResult<int>(messageError: "Not found user");
            }

            var identityResult = await _userManager.ConfirmEmailAsync(userEntity, code);

            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return new ServiceResult<int>(messageError: errors);
            }

            return new ServiceResult<int> { Success = true };
        }

        public async Task<ServiceResult<int>> ManageInfo()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<int>> Register(string userName, string email, string password)
        {
            var userEntity = new User
            {
                UserName = userName,
                Email = email,
            };

            var identityResult = await _userManager.CreateAsync(userEntity, password);
            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return new ServiceResult<int>(messageError: errors);
            }

            identityResult = await _userManager.AddToRoleAsync(userEntity, RolesConstant.Customer);
            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return new ServiceResult<int>(messageError: errors);
            }

            return new ServiceResult<int> { Success = true };
        }

        public async Task<ServiceResult<string>> SignIn(string email, string password, bool lockoutOnFailure)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return new ServiceResult<string>(messageError: "Not exist user");
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure);

            if (signInResult.IsNotAllowed)
            {
                return new ServiceResult<string>(messageError: "Confirm your email address");
            }

            if (signInResult.IsLockedOut)
            {
                return new ServiceResult<string>(messageError: "Account locked");
            }

            if (!signInResult.Succeeded)
            {
                return new ServiceResult<string>(messageError: "Password incorrect");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new("email", email),
                new("roles", string.Join(',', roles))
            };

            var token = GenerateJwtToken(claims);
            return new ServiceResult<string>(data: token);
        }

        public async Task<string> GenerateEmailConfirmationToken(string email)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);

            if (userEntity == null)
            {
                return string.Empty;
            }
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userEntity);
            return token;
        }

        public async Task<ServiceResult<int>> ForgotPassword(string email)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity == null)
            {
                return new ServiceResult<int>(messageError: "Not found user");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(userEntity);
            await _emailSenderService.SendPasswordResetCodeAsync(userEntity.UserName, email, code);

            return new ServiceResult<int> { Success = true };
        }

        public async Task<ServiceResult<int>> ResetPassword(string email, string resetCode, string newPassword)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity == null)
            {
                return new ServiceResult<int>(messageError: "Not found user");
            }

            var identityResult = await _userManager.ResetPasswordAsync(userEntity, resetCode, newPassword);
            if (identityResult.Errors.Any())
            {
                var error = identityResult.Errors.First().Description;
                return new ServiceResult<int>(messageError: error);
            }

            return new ServiceResult<int> { Success = true };
        }

        public async Task<ServiceResult<int>> Manage2Fa()
        {
            throw new NotImplementedException();
        }
    }
}
