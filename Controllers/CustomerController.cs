using Microsoft.AspNetCore.Mvc;
using DB1BankExpress.Models;
using DB1BankExpress.Services;

namespace DB1BankExpress.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
  private readonly ICustomerService _service;

  public CustomerController(ICustomerService service)
  {
    _service = service;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(_service.GetAll());
  }

  [HttpPost]
  public IActionResult Post([FromBody] Customer customer)
  {
    return Created("", _service.Save(customer));
  }

  [HttpPut]
  public IActionResult Put([FromBody] Customer customer)
  {
    return Ok(_service.Change(customer));
  }

  [HttpDelete]
  public IActionResult Delete(Guid id)
  {
    _service.Delete(id);

    return NoContent();
  }
}

