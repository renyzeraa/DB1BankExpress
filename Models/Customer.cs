using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DB1BankExpress.Models;

public class Customer
{
  [Key]
  public Guid Id { get; set; }
  public string Name { get; set; }

  public Customer(string name)
  {
    Id = Guid.NewGuid();
    Name = name;
  }
}