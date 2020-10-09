using Microsoft.EntityFrameworkCore;
using Urutransporte.Domain;

namespace Urutransporte.DataAccess
{
    public class UrutransporteContext : DbContext
    {
        public DbSet<Transporter> Transporters{get; set;}
        public UrutransporteContext(DbContextOptions<UrutransporteContext> options) : base(options) { }
    }
}