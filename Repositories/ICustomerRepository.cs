using DB1BankExpress.Models;

namespace DB1BankExpress.Repositories;

public interface ICustomerRepository
{
  IEnumerable<Customer> GetAll();
  Customer Save(Customer customer);
  Customer? Find(Guid id);
  Customer Change(Customer customer);
  void Delete(Guid id);
}
