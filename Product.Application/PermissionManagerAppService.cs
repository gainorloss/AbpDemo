using Microsoft.IdentityModel.Tokens;
using Product.Application.Constracts.Products;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.PermissionManagement;

namespace Product.Application
{
    public class PermissionManagerAppService : ApplicationService, IPermissionManagerAppService
    {
        private readonly IPermissionManager _manager;

        public PermissionManagerAppService(IPermissionManager manager)
        {
            _manager = manager;
        }

        public Task<string> GetAuthAsync()
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, "TestUser"),
                new Claim(ClaimTypes.Role, "admin"),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456"));

            var token = new JwtSecurityToken(
                issuer: "Issuer",
                audience: "Audience",
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return Task.FromResult(jwtToken);
        }

        public async Task RemovePermissionAsync()
        {
            await _manager.SetAsync(ProductManagementPermissions.Products.Default, "C", "admin", false);
        }

        public async Task SetPermissionAsync()
        {
           await _manager.SetAsync(ProductManagementPermissions.Products.Default, "R", "admin", true);
        }
    }
}
