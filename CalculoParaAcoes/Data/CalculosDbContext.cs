using CalculoParaAcoes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoes.Data
{
    public class CalculosDbContext : DbContext
    {
        public CalculosDbContext(DbContextOptions<CalculosDbContext> options) : base(options)
        {

        }
        public DbSet<Zscore> Zscore { get; set; }
        public DbSet<DesvioPadrao> DesvioPadrao { get; set; }
    }
}
