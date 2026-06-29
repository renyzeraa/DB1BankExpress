using DB1BankExpress.Dtos;
using DB1BankExpress.Models;

namespace DB1BankExpress.Services
{
  public interface ICustomerService
  {
    IEnumerable<Customer> GetAll();
    Customer Save(Customer customer);
    Customer Find(Guid id);
    Customer Change(CustomerUpdate update);
    void Delete(Guid id);
  }
}
