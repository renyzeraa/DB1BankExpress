using AutoMapper;
using DB1BankExpress.Dtos;
using DB1BankExpress.Models;

namespace DB1BankExpress.Configs;

public class CustomerProfile : Profile
{
  public CustomerProfile()
  {
    CreateMap<CustomerUpdate, Customer>();
  }
}