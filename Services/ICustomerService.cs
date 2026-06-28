using DB1BankExpress.Models;

namespace DB1BankExpress.Services
{
  public interface ICustomerService
  {
    IEnumerable<Customer> GetAll();
    Customer Save(Customer customer);
    Customer Find(Guid id);
    Customer Change(Customer customer);
    void Delete(Guid id);
  }
}
