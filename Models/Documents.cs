using System.ComponentModel.DataAnnotations;

namespace DB1BankExpress.Models;

public class Documents
{
  [Key]
  public Guid Id { get; set; }
  public string RgDocument { get; set; }
  public string SecurityNumber { get; set; }
  public string IssuingInstitution { get; set; }
  public string Uf { get; set; }

}