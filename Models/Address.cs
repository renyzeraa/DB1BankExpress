using System.ComponentModel.DataAnnotations;

namespace DB1BankExpress.Models;

public class Address
{
  [Key]
  public Guid Id { get; set; }
  public string Cep { get; set; } 
  public string Neighborhood { get; set; } 
  public string ResidenceNumber { get; set; } 
  public string City { get; set; } 
  public string Uf { get; set; } 
  public string PublicPlace { get; set; } 
  public string AddtionalInformation { get; set; } 
}