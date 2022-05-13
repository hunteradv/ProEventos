using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options) { }
        public DbSet<Event> Events { get; set; }
    }
}