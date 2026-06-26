using DB1BankExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace DB1BankExpress.Context;

public class AppDbContext : DbContext
{
    // declaração obrigatória do construtor da classe AppDbContext, que recebe um objeto DbContextOptions<AppDbContext> como parâmetro e o passa para a classe base DbContext.
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
}