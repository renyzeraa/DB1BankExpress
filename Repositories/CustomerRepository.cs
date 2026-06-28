using DB1BankExpress.Context;
using DB1BankExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace DB1BankExpress.Repositories;

public class CustomerRepository : ICustomerRepository
{
  private readonly AppDbContext _context;

  public CustomerRepository(AppDbContext context)
  {
    _context = context;
  }

  public IEnumerable<Customer> GetAll()
  {
    return _context.Customers
      .Include(c => c.Address)
      .Include(c => c.Documents)
      .AsNoTracking();
  }

  public Customer Save(Customer customer)
  {
    var saved = _context.Customers.Add(customer);
    _context.SaveChanges();

    return saved.Entity;
  }

  public Customer? Find(Guid id)
  {
    return _context.Customers.Find(id);
  }

  public Customer Change(Customer customer)
  {
    var updated = _context.Customers.Update(customer);
    _context.SaveChanges();

    return updated.Entity;
  }

  public void Delete(Guid id)
  {
    var existingCustomer = _context.Customers.FirstOrDefault(c => c.Id == id);
    if (existingCustomer == null) return;

    _context.Customers.Remove(existingCustomer);
    _context.SaveChanges();
  }

}
