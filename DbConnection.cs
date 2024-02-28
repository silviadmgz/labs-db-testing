using labs_db_testing.Models;
using Microsoft.EntityFrameworkCore;

namespace labs_db_testing;

public class DbConnection : DbContext
{
    public DbSet<Items> Items { get; set; }

    public DbConnection(DbContextOptions<DbConnection> options)
        : base(options)
    {
    }
}