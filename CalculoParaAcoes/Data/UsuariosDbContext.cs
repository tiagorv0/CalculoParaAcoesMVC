using CalculoParaAcoesMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Data
{
    public class UsuariosDbContext : IdentityDbContext
    {
        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> opt) : base(opt)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
