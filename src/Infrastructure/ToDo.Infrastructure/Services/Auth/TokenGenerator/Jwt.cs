using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Infrastructure.Auth.TokenGenerator;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Application.DTOs.Authentication;
using ToDo.Application.Utilities.Encoder;
using ToDo.Domain.Entities.Role;
using ToDo.Domain.Entities.User;

namespace ToDo.Infrastructure.Services.Auth.TokenGenerator
{
	public class Jwt : IJwt
	{
		private readonly IUserRepositoryDapper _userRepositoryDapper;
		private readonly IRoleRepositoryDapper _roleRepositoryDapper;
        public Jwt(IUserRepositoryDapper userRepositoryDapper,IRoleRepositoryDapper roleRepositoryDapper)
        {
            _userRepositoryDapper = userRepositoryDapper;
			_roleRepositoryDapper = roleRepositoryDapper;
        }
        public async Task<string> GenerateToken(LoginDto loginDto)
		{
			User user = _userRepositoryDapper.Get(u=>u.Email==loginDto.Email).Result[0];
			List<Role> roles = _roleRepositoryDapper.GetRolesOfUser(user.Id).Result.ToList();
			if (user != null && user.Email == loginDto.Email && user.Password == PasswordEncoder.EncodePasswordMd5(loginDto.Password))
			{
				#region Claims
				var authClaims = new List<System.Security.Claims.Claim>
				{
					 new System.Security.Claims.Claim(ClaimTypes.NameIdentifier,user.Id),
					 new System.Security.Claims.Claim(ClaimTypes.Name,user.Email),
				};
				foreach (var userRole in roles)
				{
					authClaims.Add(new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Role, userRole.Title));
				}
				#endregion
				var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ToDoApiToDoApiToDoApiToDoApiToDoApiToDoA"));
				var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature);
				var encryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567891011121"));
				var encryptionCredentials = new EncryptingCredentials(encryptionKey, SecurityAlgorithms.Aes128KW,
					SecurityAlgorithms.Aes128CbcHmacSha256);


				var descriptor = new SecurityTokenDescriptor()
				{
					Subject = new ClaimsIdentity(authClaims),
					Audience = "Account",
					Issuer = "AccountServer",
					IssuedAt = DateTime.Now,
					Expires = DateTime.Now.AddDays(30),
					NotBefore = DateTime.Now,
					SigningCredentials = signingCredentials,
					EncryptingCredentials = encryptionCredentials,
					CompressionAlgorithm = CompressionAlgorithms.Deflate,
				};
				var tokenHandler = new JwtSecurityTokenHandler();
				var securityToken = tokenHandler.CreateToken(descriptor);

				var tokenResult = tokenHandler.WriteToken(securityToken);


				return await _userRepositoryDapper.GenerateToken(user.Id, tokenResult) ==true? tokenResult : string.Empty;
			}
			return string.Empty;
		}
	}
}
