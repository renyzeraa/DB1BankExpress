using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DB1BankExpress.Models;

public class Customer
{
  [Key]
  public Guid Id { get; set; }
  [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
  [MaxLength(150, ErrorMessage = "O nome do cliente não pode exceder 150 caracteres.")]
  public string Name { get; set; }

  public Customer(string name)
  {
    Id = Guid.NewGuid();
    Name = name;
  }
}