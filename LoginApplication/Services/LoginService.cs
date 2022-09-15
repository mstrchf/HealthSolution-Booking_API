using LoginApplication.DbContexts;
using LoginApplication.Models;
using LoginApplication.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LoginApplication.Services
{
    public class LoginService : ILoginService
    {
        private readonly LoginDbContext _context;
        private readonly IConfiguration _configuration;

        public LoginService(LoginDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }
        //registration
        public async Task<Profile> Register(UserLogin user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new Profile() { Username = user.Username, Token = GenerateToken(user) };
        }

        //login
        public async Task<Profile>Login(User user)
        {
            var User = await _context.Users.SingleOrDefaultAsync(u => u.Username == user.Username);
            if(User == null)
            {
                return null;
            }
            var result = BCrypt.Net.BCrypt.Verify(user.Password, User.Password) ? new Profile() { Username = User.Username, Token = GenerateToken(User) } : null;
            return result;
        }

        private string GenerateToken(UserLogin user)
        {
            var claims = new[]
            {
                new Claim (JwtRegisteredClaimNames.Sub, user.Username),
                new Claim (JwtRegisteredClaimNames. Email, user.Username),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };


            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
                
        }
    }
}
