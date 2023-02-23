using CMSSERVICE.DOMAIN.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

internal sealed class JwtProvider : IJwtProvider
{
    private readonly JwtOptions _options;
    private readonly ApplicationDbContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;
    public JwtProvider(IOptions<JwtOptions> options, ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
    {
        _options = options.Value;
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
    }

    public string Generate(LoginDetail user)
    {
        var jwtTokenHandler = new JwtSecurityTokenHandler();

        ////var key = Convert.FromBase64String(_options.SecretKey);

        var key = Encoding.UTF8.GetBytes(_options.SecretKey);

        var claims = GetAllValidClaims(user);

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_options.ExpiryTimeFrame)),
            SigningCredentials = signingCredentials
        };

        var token = jwtTokenHandler.CreateToken(tokenDescriptor);

        ////var token = new JwtSecurityToken(
        ////    _options.Issuer,
        ////    _options.Audience,
        ////    claims,
        ////    null,
        ////    DateTime.UtcNow.AddHours(1),
        ////    signingCredentials);

        ////var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
        var tokenValue = jwtTokenHandler.WriteToken(token);

        var loginDetailInfo = _dbContext.Set<LoginDetail>().FirstOrDefault(x => x.Id == user.Id);
        if (loginDetailInfo != null)
        {
            loginDetailInfo.AccessToken = tokenValue;
            loginDetailInfo.LastLogin = DateTime.UtcNow;
            _dbContext.Set<LoginDetail>().Update(loginDetailInfo);
        }

        _unitOfWork.SaveChangesAsync();

        return tokenValue;
    }

    /// <summary>
    /// Get All Valid Claims.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public List<Claim> GetAllValidClaims(LoginDetail user)
    {
        var claims = new List<Claim>
        {
            new Claim("Id", user.Id.ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.LoginId),
            new Claim(JwtRegisteredClaimNames.Sub, user.LoginId),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        // Getting the claims that we have assigned to the user
        var role = string.Empty;

        if (user.ClientId != null)
        {
            role = string.Format("Client|{0}", user.ClientId);
        }

        if (user.LawPracticeId != null)
        {
            role = string.Format("LawPractice|{0}", user.LawPracticeId);
        }

        if (user.LocalCounselId != null)
        {
            role = string.Format("LocalCounsel|{0}", user.LawPracticeId);
        }

        if (Convert.ToBoolean(user.IsAdmin) || Convert.ToBoolean(user.IsSuperAdmin) || Convert.ToBoolean(user.IsSysAdmin))
        {
            role = string.Format("Admin|{0}", "Admin");
        }

        if (!string.IsNullOrEmpty(role))
        {
            claims.Add(new Claim(ClaimTypes.Role, role.Split("|")[0]));
            claims.Add(new Claim(role.Split("|")[0], role.Split("|")[1]));
        }

        return claims;
    }
}
