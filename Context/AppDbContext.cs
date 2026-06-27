using DB1BankExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace DB1BankExpress.Context;

public class AppDbContext : DbContext
{
    // declaração obrigatória do construtor da classe AppDbContext, que recebe um objeto DbContextOptions<AppDbContext> como parâmetro e o passa para a classe base DbContext.
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasOne(e => e.Documents)
            .WithOne()
            .HasForeignKey<Documents>(e => e.Id)
            .IsRequired();

        modelBuilder.Entity<Customer>()
            .HasOne(e => e.Address)
            .WithOne()
            .HasForeignKey<Address>(e => e.Id)
            .IsRequired();
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Documents> Documents => Set<Documents>();
    public DbSet<Address> Address => Set<Address>();
}