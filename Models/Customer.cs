using System.ComponentModel.DataAnnotations;

namespace DB1BankExpress.Models;

public class Customer
{
  [Key]
  public Guid Id { get; set; }
  [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
  [MaxLength(150, ErrorMessage = "O nome do cliente não pode exceder 150 caracteres.")]
  public string Name { get; set; }
  public string LastName { get; set; }
  public DateTime BirthDate { get; set; }
  public string MotherName { get; set; }
  public string FatherName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }
  public string CellPhoneNumber { get; set; }
  public decimal MonthlyIncome { get; set; }
  public Documents Documents { get; set; }
  public Address Address { get; set; }

  public Customer(string name)
  {
    Name = name;
  }
}