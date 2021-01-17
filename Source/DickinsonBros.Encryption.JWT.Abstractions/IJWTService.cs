using DickinsonBros.Encryption.JWT.Abstractions.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace DickinsonBros.Encryption.JWT.Abstractions
{
    public interface IJWTService<T>
    {
        string GenerateJWT(IEnumerable<Claim> claims, System.DateTime expiresDateTime, TokenType tokenType);
        GenerateTokensDescriptor GenerateTokens(IEnumerable<Claim> claims);
        GenerateTokensDescriptor GenerateTokens(string accessToken, string refershToken);
        ClaimsPrincipal GetPrincipal(string token, bool vaildateLifetime, TokenType tokenType);
    }
}
