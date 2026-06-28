using DB1BankExpress.Models;
using DB1BankExpress.Repositories;

namespace DB1BankExpress.Services;

public class CustomerService : ICustomerService
{
  private readonly ICustomerRepository _repository;

  public CustomerService(ICustomerRepository repository)
  {
    _repository = repository;
  }

  public IEnumerable<Customer> GetAll()
  {
    return _repository.GetAll();
  }

  public Customer Save(Customer customer)
  {
    return _repository.Save(customer);
  }

  public Customer Find(Guid id)
  {
    return _repository.Find(id) ?? throw new InvalidOperationException($"Customer with ID {id} not found.");
  }

  public Customer Change(Customer customer)
  {
    var existingCustomer = Find(customer.Id);
    existingCustomer.Name = customer.Name;
    
    return _repository.Change(existingCustomer);
  }

  public void Delete(Guid id)
  {
    var existingCustomer = Find(id);
    _repository.Delete(existingCustomer.Id);
  }
}
