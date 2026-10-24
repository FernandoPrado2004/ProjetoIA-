using Microsoft.EntityFrameworkCore;
using ProjetoIA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIA.Infra.Data.Context
{
    public class ProjetoIAContext : DbContext
    {
        public ProjetoIAContext(DbContextOptions<ProjetoIAContext> options) : base(options) { }
        public DbSet<Produto> Produtos {  get; set; }
    }
}
