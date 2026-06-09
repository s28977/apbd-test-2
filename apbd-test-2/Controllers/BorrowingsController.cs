using apbd_test_2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace apbd_test_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BorrowingsController : ControllerBase
{
    [HttpPut]
    [Route("{id:int}/return")]
    public async Task<IActionResult> ReturnBorrowing([FromRoute] int id, [FromBody] ReturnBorrowingDto returnBorrowingDto)
    {
        return NoContent();
    }
}