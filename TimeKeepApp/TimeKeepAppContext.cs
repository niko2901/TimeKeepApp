using Microsoft.EntityFrameworkCore;
using TimeKeepApp.Models;

public class TimeKeepAppContext(DbContextOptions<TimeKeepAppContext> options) : DbContext(options)
{
    public DbSet<Employee> Employee { get; set; } = default!;
    public DbSet<TransactionType> TransactionType { get; set; } = default!;
    public DbSet<TimekeepingTransaction> TimekeepingTransaction { get; set; } = default!;
}
