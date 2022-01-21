using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CalculoParaAcoes.AuthApi.Data
{
    public class AuthDBContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options)
        {

        }
    }
}
