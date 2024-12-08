using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoIHCProva.Models;

namespace ProjetoIHCProva.Data
{
    public class ProjetoIHCProvaContext : DbContext
    {
        public ProjetoIHCProvaContext (DbContextOptions<ProjetoIHCProvaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoIHCProva.Models.Cliente> Cliente { get; set; } = default!;
    }
}
