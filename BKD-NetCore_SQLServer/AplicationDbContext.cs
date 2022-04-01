using BKD_NetCore_SQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BKD_NetCore_SQLServer
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Credit_Card> Credit_Card { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
