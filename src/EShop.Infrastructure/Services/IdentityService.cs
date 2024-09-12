using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EShop.Application.Configurations;
using EShop.Application.Constants;
using EShop.Application.Entities;
using EShop.Application.Services.ApplicationService;
using EShop.Application.Services.Interfaces;
using EShop.Shared.ResponseModels.Identity;
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

        public async Task<string> GenerateJwtToken(string email)
        {
            // Get claims
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return string.Empty;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new("email", email),
                new("roles", string.Join(',', roles))
            };

            // GenerateToken
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

        public async Task<bool> CheckExistUserByEmailAsync(string email)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            return userEntity != null;
        }

        public Task<string> RefreshToken(string oldToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult> ConfirmEmail(string email, string code)
        {

            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity is null)
            {
                return ServiceResult.Failed("Not found user");
            }

            var identityResult = await _userManager.ConfirmEmailAsync(userEntity, code);

            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return ServiceResult.Failed(errors);
            }

            return ServiceResult.Success;
        }

        public async Task<ManageInfoResponse> ManageInfo(string jwtToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(jwtToken);
            if (jwtSecurityToken != null)
            {
                var email = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
                var roles = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "roles")?.Value;

                return new ManageInfoResponse
                {
                    Email = email ?? "",
                    Roles = roles?.Split(",").ToList() ?? new(),
                };
            }

            return new ManageInfoResponse
            {
                Email = "",
                Roles = new(),
            };
        }

        public async Task<ServiceResult> Register(string userName, string email, string password)
        {
            var userEntity = new User
            {
                UserName = userName,
                Email = email,
                AvatarUrl = "",
            };

            var identityResult = await _userManager.CreateAsync(userEntity, password);
            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return ServiceResult.Failed(errors);
            }

            identityResult = await _userManager.AddToRoleAsync(userEntity, RolesConstant.Customer);
            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return ServiceResult.Failed(errors);
            }

            return ServiceResult.Success;
        }

        public async Task<ServiceResult> SignIn(string email, string password, bool lockoutOnFailure)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return ServiceResult.Failed("Not exist user");
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure);

            if (signInResult.IsNotAllowed)
            {
                return ServiceResult.Failed("Confirm your email address");
            }

            if (signInResult.IsLockedOut)
            {
                return ServiceResult.Failed("Account locked");
            }

            if (!signInResult.Succeeded)
            {
                return ServiceResult.Failed("Password incorrect");
            }

            return ServiceResult.Success;
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

        public async Task<ServiceResult> ForgotPassword(string email)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity == null)
            {
                return ServiceResult.Failed("Not found user");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(userEntity);
            var serviceResult = await _emailSenderService.SendPasswordResetCodeAsync(userEntity.UserName, email, code);

            return serviceResult;
        }

        public async Task<ServiceResult> ResetPassword(string email, string resetCode, string newPassword)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            if (userEntity == null)
            {
                return ServiceResult.Failed("Not found user");
            }

            var identityResult = await _userManager.ResetPasswordAsync(userEntity, resetCode, newPassword);
            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return ServiceResult.Failed(errors);

            }
            return ServiceResult.Success;
        }

        public async Task<ServiceResult> Manage2Fa()
        {
            throw new NotImplementedException();
        }
    }
}
