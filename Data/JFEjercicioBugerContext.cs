using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JFEjercicioBuger.Models;

namespace JFEjercicioBuger.Data
{
    public class JFEjercicioBugerContext : DbContext
    {
        public JFEjercicioBugerContext (DbContextOptions<JFEjercicioBugerContext> options)
            : base(options)
        {
        }

        public DbSet<JFEjercicioBuger.Models.Burguer> Burguer { get; set; } = default!;
        public DbSet<JFEjercicioBuger.Models.Promo> Promo { get; set; } = default!;
    }
}
