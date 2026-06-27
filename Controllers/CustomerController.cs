using Microsoft.AspNetCore.Mvc;
using DB1BankExpress.Models;
using DB1BankExpress.Context;
using Microsoft.EntityFrameworkCore;
namespace DB1BankExpress.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
  private readonly AppDbContext _context;

  public CustomerController(AppDbContext context)
  {
    _context = context;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var customers = _context.Customers
      .Include(c => c.Address)
      .Include(c => c.Documents)
      .AsNoTracking();
    return Ok(customers);
  }

  [HttpPost]
  public IActionResult Post([FromBody] Customer customer)
  {
    _context.Customers.Add(customer);
    _context.SaveChanges();
    return CreatedAtAction(nameof(Get), new { name = customer.Name }, customer);
  }

  [HttpPut]
  public IActionResult Put([FromBody] Customer customer)
  {
    var existingCustomer = _context.Customers.Where(c => c.Id == customer.Id).FirstOrDefault();
    if (existingCustomer == null)
    {
      return NotFound();
    }

    existingCustomer.Name = customer.Name;
    _context.SaveChanges();
    return Ok(existingCustomer);
  }

  [HttpDelete]
  public IActionResult Delete(Guid Id)
  {
    var existingCustomer = _context.Customers.Where(c => c.Id == Id).FirstOrDefault();
    if (existingCustomer == null)
    {
      return NotFound();
    }

    _context.Customers.Remove(existingCustomer);
    _context.SaveChanges();
    return NoContent();
  }
}

