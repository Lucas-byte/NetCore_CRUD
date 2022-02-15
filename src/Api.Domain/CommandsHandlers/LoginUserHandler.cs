using Domain.Commands;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Security;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.CommandsHandlers
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, object>
    {
        private readonly IUserRepositoryEF _userRepository;
        private readonly TokenConfigurations _tokenConfigurations;
        private readonly SigningConfigurations _signingConfigurations;
        public LoginUserHandler(IUserRepositoryEF userRepository,
            TokenConfigurations tokenConfigurations,
            SigningConfigurations signingConfigurations)
        {
            _userRepository = userRepository;
            _tokenConfigurations = tokenConfigurations;
            _signingConfigurations = signingConfigurations;
        }

        public async Task<object> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(request.Email) && !string.IsNullOrEmpty(request.Password))
            {
                var user = await _userRepository.FindByLogin(request.Email, request.Password);

                if (user == null)
                {
                    return NoSucessObject();
                }
                else
                {
                    var identity = new ClaimsIdentity(
                        new GenericIdentity(user.Email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.Name),
                        }
                     );

                    var handler = new JwtSecurityTokenHandler();

                    var createDate = DateTime.Now;
                    var expiredDate = createDate + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

                    var token = CreateToken(identity, createDate, expiredDate, handler);

                    return SucessObject(createDate, expiredDate, token, user);
                }
            }
            else
            {
                return NoSucessObject();
            }
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate,
            });

            var token = handler.WriteToken(securityToken);

            return token;
        }

        private object SucessObject(DateTime createDate, DateTime expirationDate, string token, UserEF userEF)
        {
            return new
            {
                Authenticated = true,
                Created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                Expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                AcessToken = token,
                UserEmail = userEF.Email,
                UserName = userEF.Name,
                Message = "Usuário Logado com sucesso"
            };
        }

        private object NoSucessObject()
        {
            return new
            {
                Authenticated = false,
                Message = "Falha ao autenticar"
            };
        }
    }
}
