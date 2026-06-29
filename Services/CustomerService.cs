using AutoMapper;
using DB1BankExpress.Dtos;
using DB1BankExpress.Models;
using DB1BankExpress.Repositories;

namespace DB1BankExpress.Services;

public class CustomerService : ICustomerService
{
  private readonly ICustomerRepository _repository;
  private readonly IMapper _mapper;

  public CustomerService(ICustomerRepository repository, IMapper mapper)
  {
    _repository = repository;
    _mapper = mapper;
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

  public Customer Change(CustomerUpdate update)
  {
    var existingCustomer = Find(update.Id);
    _mapper.Map(update, existingCustomer);

    return _repository.Change(existingCustomer);
  }

  public void Delete(Guid id)
  {
    var existingCustomer = Find(id);
    _repository.Delete(existingCustomer.Id);
  }
}
